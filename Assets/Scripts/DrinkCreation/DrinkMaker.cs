using UnityEngine;

public class DrinkMaker : MonoBehaviour
{
    public static DrinkMaker Instance { get; private set; }
    public Cup selectedCup;

    [SerializeField] private GameObject rocksCup;
    [SerializeField] private GameObject martiniCup;
    [SerializeField] private GameObject collinsCup;

    private bool isSelected = false;

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
        if(!isSelected)
        {
            selectedCup = cup;

            if (selectedCup.cupType == CupType.Martini)
            {
                martiniCup.SetActive(true);
            }
            else if (selectedCup.cupType == CupType.Rocks)
            {
                rocksCup.SetActive(true);
            }
            else if (selectedCup.cupType == CupType.Collins)
            {
                collinsCup.SetActive(true);
            }

            isSelected = true;
        }

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

    public void RestartDrink()
    {
        selectedCup = null;
        isSelected = false;
        martiniCup.SetActive(false);
        rocksCup.SetActive(false);
        collinsCup.SetActive(false);
    }


}
