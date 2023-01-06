namespace FoodDailyValueCalculator;

internal class Program
{
    private static void Main()
    {
        var apple = new Apple();
        var calculator = new FoodDailyValueCalculator(apple, 2400);
        var dailyValue = calculator.Calculate();

        Console.WriteLine("Calories: {0:0.00}%", dailyValue.Calories);
        Console.WriteLine("Fat: {0:0.00}%", dailyValue.Fat);
        Console.WriteLine("Protein: {0:0.00}%", dailyValue.Protein);
        Console.WriteLine("Carbs: {0:0.00}%", dailyValue.Carbohydrates);
        Console.WriteLine("Fiber: {0:0.00}%", dailyValue.Fiber);
        Console.WriteLine("Sugar: {0:0.00}%", dailyValue.Sugar);
        Console.WriteLine("Vitamin C: {0:0.00}%", dailyValue.VitaminC);
        Console.WriteLine("Calcium: {0:0.00}%", dailyValue.Calcium);
        Console.WriteLine("Iron: {0:0.00}%", dailyValue.Iron);

    }

    private class Apple : Food
    {
        public Apple() : base(95, 0.3, 1, 25, 3, 19, 8, 6, 0.4)
        {
        }
    }
}