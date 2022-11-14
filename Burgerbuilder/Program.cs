using Burgerbuilder.Kitchen;



var exit = false;
while (!exit)
{
    PrintMenu();
}

void PrintMenu()
{
    Console.OutputEncoding = System.Text.Encoding.Unicode;



    Console.WriteLine("აირჩიეთ შეკვეთის რეჟიმი:");
    Console.WriteLine("1. წინასწარ გამზადებული ბურგერები");
    Console.WriteLine("2. ბურგერის აწყობა");


    Console.Write("");
    int.TryParse(Console.ReadLine(), out var BurgerKind);


    var cheeseburger = new Burger(meltedCheese:true,pickles:true,meat:null,sauce: "Spicy", lettuce:true,cookie:true);
    var hamburger = new Burger(meltedCheese: false, pickles: true, meat: "Beef", sauce: "Sweet", lettuce: true, cookie: true);
    var branded = new Burger(meltedCheese: false, pickles: true, meat: "Chicken", sauce: "Branded", lettuce: true, cookie: true);


    if (BurgerKind == 1)
    {
        Console.WriteLine("1. Cheeseburger");
        Console.WriteLine("2. Hamburger");
        Console.WriteLine("3. Branded");
        Console.Write("");
        int.TryParse(Console.ReadLine(), out var BurgerType);
        if (BurgerType == 1)
        {
            Console.WriteLine($"{cheeseburger}");
        }
        else if (BurgerType == 2)
        {
            Console.WriteLine($"{hamburger}");
        }
        else if (BurgerType == 3)
        {
            Console.WriteLine($"{branded}");
        }
    }
    else if (BurgerKind == 2)
    {
         bool MeltedCheese;
         bool Pickles;
         string Meat;
         string Sauce;
         bool Lettuce = true;
         bool Cookie = true;
        Console.Write("1. ჰქონდეს მდნარი ყველი?\n") ;
        bool.TryParse(Console.ReadLine(), out MeltedCheese);
        Console.Write("2. ჰქონდეს მჟავე კიტრი?\n");
        bool.TryParse(Console.ReadLine(), out Pickles);
        Console.Write("3. აირჩიეთ ხორცი:\n1.ქათმის\n2.საქონლის\n3.არცერთი\n");
        Meat = Console.ReadLine();
        Console.Write("3. აირჩიეთ სოუსი:\n1.ცხარე\n2.ტკბილი\n3.საფირმო\n4.არცერთი\n");
        Sauce = Console.ReadLine();

        Console.WriteLine($"MeltedCheese: {MeltedCheese} \nPickles: {Pickles}\nMeat: {Meat}\nSauce: {Sauce}\nLettuce:{Lettuce}\nCookie:{Cookie}");

    }
    



}