namespace FoodDailyValueCalculator;

public class FoodDailyValueCalculator
{
    private const int FatGramsPerDay = 65;
    private const int ProteinGramsPerDay = 50;
    private const int CarbsGramsPerDay = 300;
    private const int FiberGramsPerDay = 25;
    private const int SugarGramsPerDay = 25;
    private const int VitaminCMilligramsPerDay = 90;
    private const int CalciumMilligramsPerDay = 1000;
    private const int IronMilligramsPerDay = 18;
    private readonly int _dailyCalories;
    private readonly Food _food;

    public FoodDailyValueCalculator(Food food, int dailyCalories)
    {
        this._food = food;
        this._dailyCalories = dailyCalories;
    }

    public DailyValue Calculate()
    {
        return new DailyValue
        {
            Calories = CalculateCalories(),
            Fat = CalculateFat(),
            Protein = CalculateProtein(),
            Carbohydrates = CalculateCarbs(),
            Fiber = CalculateFiber(),
            Sugar = CalculateSugar(),
            VitaminC = CalculateVitaminC(),
            Calcium = CalculateCalcium(),
            Iron = CalculateIron()
        };
    }

    private double CalculateCalories()
    {
        return _food.Calories / _dailyCalories * 100;
    }

    private double CalculateFat()
    {
        return _food.Fat / FatGramsPerDay * 100;
    }

    private double CalculateProtein()
    {
        return _food.Protein / ProteinGramsPerDay * 100;
    }

    private double CalculateCarbs()
    {
        return _food.Carbohydrates / CarbsGramsPerDay * 100;
    }

    private double CalculateFiber()
    {
        return _food.Fiber / FiberGramsPerDay * 100;
    }

    private double CalculateSugar()
    {
        return _food.Sugar / SugarGramsPerDay * 100;
    }

    private double CalculateVitaminC()
    {
        return _food.VitaminC / VitaminCMilligramsPerDay * 100;
    }

    private double CalculateCalcium()
    {
        return _food.Calcium / CalciumMilligramsPerDay * 100;
    }

    private double CalculateIron()
    {
        return _food.Iron / IronMilligramsPerDay * 100;
    }
}