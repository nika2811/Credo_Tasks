using System.Text;
using Burgerbuilder.Kitchen;

var exit = false;
while (!exit) PrintMenu();
exit = true;
void PrintMenu()
{
    Console.OutputEncoding = Encoding.Unicode;


    Console.WriteLine("Airchie shekvetis rejimi:");
    Console.WriteLine("1. Winaswar gamzadebuli burgerebi");
    Console.WriteLine("2. Burgeris awyoba");


    Console.Write("");
    int.TryParse(Console.ReadLine(), out var BurgerKind);


    var cheeseburger = new Burger(true, true, null, "Spicy", true, true);
    var hamburger = new Burger(false, true, "Beef", "Sweet", true, true);
    var branded = new Burger(false, true, "Chicken", "Branded", true, true);


    if (BurgerKind == 1)
    {
        Console.WriteLine("1. Cheeseburger");
        Console.WriteLine("2. Hamburger");
        Console.WriteLine("3. Branded");
        Console.Write("");

        int.TryParse(Console.ReadLine(), out var BurgerType);

        if (BurgerType == 1)
            Console.WriteLine($"{cheeseburger}");
        else if (BurgerType == 2)
            Console.WriteLine($"{hamburger}");
        else if (BurgerType == 3) Console.WriteLine($"{branded}");
    }
    else if (BurgerKind == 2)
    {
        bool MeltedCheese;
        bool Pickles;
        string Meat;
        string Sauce;
        var Lettuce = true;
        var Cookie = true;

        Console.Write("1. Hqondes mdnari yveli?(true/false)\n");
        bool.TryParse(Console.ReadLine(), out MeltedCheese);

        Console.Write("2. Hqondes mjave kitri?(true/false)\n");
        bool.TryParse(Console.ReadLine(), out Pickles);

        Console.Write("3. Airchie xorci(akrife erterti):\n1.qatmis\n2.saqonlis\n3.arcerti\n");
        Meat = Console.ReadLine();

        Console.Write("3.  Airchie sousi(akrife erterti):\n1.cxare\n2.tkbili\n3.safirmo\n4.arcerti\n");
        Sauce = Console.ReadLine();

        Console.WriteLine(
            $"MeltedCheese: {MeltedCheese} \nPickles: {Pickles}\nMeat: {Meat}\nSauce: {Sauce}\nLettuce:{Lettuce}\nCookie:{Cookie}");
    }
}