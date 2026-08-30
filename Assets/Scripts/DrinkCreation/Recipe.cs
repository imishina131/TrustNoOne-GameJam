using System;
using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(menuName = "Scriptable Objects/Recipe")]
public class Recipe : ScriptableObject
{
    public CupType requiredCup;
    public List<IngredientAmount> requiredIngredients;
}

[Serializable]
public class IngredientAmount
{
    public Ingredients ingredient;
    public float amount;
}