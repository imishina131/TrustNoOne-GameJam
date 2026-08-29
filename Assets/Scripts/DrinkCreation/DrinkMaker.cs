using UnityEngine;

public class DrinkMaker : MonoBehaviour
{
    public static DrinkMaker Instance { get; private set; }
    private Cup selectedCup;

    void Awake()
    {
        Instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectCup(Cup cup)
    {
        selectedCup = cup;

        Debug.Log("Selected cup: " + cup.name);
    }

    public void PourLiquid(Ingredients ingredient, float amount)
    {
        if(selectedCup == null)
        {
            Debug.Log("no cup!");
            return;
        }

        selectedCup.AddIngredient(ingredient, amount);
    }
}
