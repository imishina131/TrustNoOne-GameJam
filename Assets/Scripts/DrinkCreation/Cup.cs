using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Cup : MonoBehaviour
{
    public float liquidAmountInCup = 0f;
    public float maxLiquid = 3f;

    public CupType cupType;
    public Dictionary<Ingredients, float> ingredients = new Dictionary<Ingredients, float>();

    [SerializeField] private GameObject doneButton;


    public void AddIngredient(Ingredients ingredient,float amount)
    {
        if (ingredients.ContainsKey(ingredient))
        {
            ingredients[ingredient] += amount;
            //liquidAmountInCup += amount;
        }
        else if(liquidAmountInCup <= maxLiquid)
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
        maxLiquid = maxLiquid -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(liquidAmountInCup >= maxLiquid)
        {
            doneButton.SetActive(true);
        }
        */
    }
}
