namespace FoodDailyValueCalculator;

public class Food
{
    protected Food(double calories, double fat, double protein, double carbs, double fiber, double sugar,
        double vitaminC, double calcium, double iron)
    {
        Calories = calories;
        Fat = fat;
        Protein = protein;
        Carbohydrates = carbs;
        Fiber = fiber;
        Sugar = sugar;
        VitaminC = vitaminC;
        Calcium = calcium;
        Iron = iron;
    }

    public double Calories { get; set; }
    public double Fat { get; set; }
    public double Protein { get; set; }
    public double Carbohydrates { get; set; }
    public double Fiber { get; set; }
    public double Sugar { get; set; }
    public double VitaminC { get; set; }
    public double Calcium { get; set; }
    public double Iron { get; set; }
}