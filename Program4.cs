using System;
using System.Collections.Generic;

public interface IMealPlan
{
    string GetMealDescription();
}

public class VegMeal : IMealPlan
{
    public string GetMealDescription()
    {
        return "Vegetarian meal with plant-based ingredients.";
    }
}

public class VeganMeal : IMealPlan
{
    public string GetMealDescription()
    {
        return "Vegan meal with no animal products.";
    }
}

public class NonVegMeal : IMealPlan
{
    public string GetMealDescription()
    {
        return "NonVeg meal with low-carb and high-fat ingredients.";
    }
}

public class HighProteinMeal : IMealPlan
{
    public string GetMealDescription()
    {
        return "High-protein meal with lean meats and protein foods.";
    }
}

public class Meal<T> where T : IMealPlan
{
    public T MealType { get; set; }

    public Meal(T mealType)
    {
        MealType = mealType;
    }

    public void GenerateMealPlan()
    {
        Console.WriteLine(MealType.GetMealDescription());
    }
}

public static class MealPlanGenerator
{
    public static void ValidateAndGenerateMeal<T>(T meal) where T : IMealPlan
    {
        meal.GetMealDescription();
        Console.WriteLine("Meal plan successfully Executed.");
    }
}

class Program4
{
    static void Main()
    {
        var vegetarianMeal = new Meal<VegMeal>(new VegMeal());
        var veganMeal = new Meal<VeganMeal>(new VeganMeal());
        var nonvegMeal = new Meal<NonVegMeal>(new NonVegMeal());
        var highProteinMeal = new Meal<HighProteinMeal>(new HighProteinMeal());

        vegetarianMeal.GenerateMealPlan();
        veganMeal.GenerateMealPlan();
        nonvegMeal.GenerateMealPlan();
        highProteinMeal.GenerateMealPlan();

        Console.WriteLine();

        MealPlanGenerator.ValidateAndGenerateMeal(new VegMeal());
        MealPlanGenerator.ValidateAndGenerateMeal(new VeganMeal());
    }
}
