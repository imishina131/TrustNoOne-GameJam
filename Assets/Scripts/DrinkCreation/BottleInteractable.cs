using UnityEngine;

public class BottleInteractable : MonoBehaviour
{
    [SerializeField] private Ingredients ingredient;
    [SerializeField] private float amountOZ = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pour()
    {
        DrinkMaker.Instance.PourLiquid(ingredient, amountOZ);
    }
}
