using UnityEngine;

public class DrinkMaker : MonoBehaviour
{
    public static DrinkMaker Instance { get; private set; }
    public Cup selectedCup;

    [SerializeField] private GameObject rocksCup;
    [SerializeField] private GameObject martiniCup;
    [SerializeField] private GameObject collinsCup;

    [SerializeField] private OutlineSelection outline;
    public bool isSelected = false;

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
            Debug.Log("Selected cup: " + cup.name);

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
        outline.cup = null;
        selectedCup = null;
        isSelected = false;
        martiniCup.SetActive(false);
        rocksCup.SetActive(false);
        collinsCup.SetActive(false);
    }


}
