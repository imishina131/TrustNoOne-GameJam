using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Cup : MonoBehaviour
{
    private float liquidAmountInCup = 0f;
    [SerializeField] private float maxLiquid = 3f;
    private Dictionary<Ingredients, float> ingredients = new Dictionary<Ingredients, float>();

    public void AddIngredient(Ingredients ingredient,float amount)
    {
        if (ingredients.ContainsKey(ingredient))
        {
            ingredients[ingredient] += amount;
            //liquidAmountInCup += amount;
        }
        else if(liquidAmountInCup <= (maxLiquid -= 1))
        {
            ingredients.Add(ingredient, amount);
            liquidAmountInCup += amount;

            Debug.Log($"Added {amount}ml of {ingredient}");
            foreach (var element in ingredients)
            {
                Debug.Log($"Key: {element.Key}, Value: {element.Value}");
            }
        }


    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
