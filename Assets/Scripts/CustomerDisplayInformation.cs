using System;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CustomerDisplayInformation : MonoBehaviour
{
    [SerializeField] private Image idImage;
    [SerializeField] private TextMeshProUGUI orderText;

    
    public void DisplayCustomerInfo(Customer customer)
    {
        Debug.Log("Preset: " + customer.Preset);
        idImage.sprite = customer.Preset.customerID;
        
        

        StringBuilder order = new StringBuilder();
        order.AppendLine($"Glass: {customer.Recipe.requiredCup}");
        
        foreach (var ingredient in customer.Recipe.requiredIngredients)
        {
            order.AppendLine($"Ingredient: {ingredient.ingredient} {ingredient.amount} oz");
        }
        orderText.text = order.ToString();

    }
    
}
