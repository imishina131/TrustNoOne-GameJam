using UnityEngine;

public static class DrinkComparison
{
    public static bool IsCorrectDrink(Cup cup, Recipe recipe)
    {
        if (cup.cupType != recipe.requiredCup) return false;

        if (cup.ingredients.Count != recipe.requiredIngredients.Count) return false;

        foreach (var ingredient in recipe.requiredIngredients)
        {
            if (!cup.ingredients.TryGetValue(ingredient.ingredient, out float actual)) return false;
            
            if(Mathf.Abs(actual - ingredient.amount) > 0.01f) return false;
        }
        return true;
    }
}
