using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class BottleInteractable : MonoBehaviour
{
    [SerializeField] private Ingredients ingredient;
    [SerializeField] private float amountOZ = 1f;
    private bool isMoving = false;
    private bool isPouring = false;
    private bool poured = false;

    public bool canPour = true;

    private Animator controller;

    private Vector3 defaultPos;

    public DrinkMaker drinkMaker;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        defaultPos = transform.localPosition;
        controller = GetComponent<Animator>();
}

    // Update is called once per frame
    void Update()
    {
        if(isMoving == true)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(0.3f, 4.0f, -1.1f), 2f * Time.deltaTime);
            if(transform.localPosition == new Vector3(0.3f, 4.0f, -1.1f))
            {
                isMoving = false;
                if(isPouring == false)
                {
                    controller.SetTrigger("Pour");
                    Invoke("SetPouring", 1f);
                }
            }
        }

        if(isPouring == true)
        {
            if(transform.eulerAngles == new Vector3(0f, 0f, 0f))
            {
                isPouring = false;
                poured = true;
            }
        }

        if(poured)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, defaultPos, 2f * Time.deltaTime);
            if(transform.localPosition == defaultPos)
            {
                poured = false;
            }
        }
    }

    private void SetPouring()
    {
        isPouring = true;
    }

    public void Pour()
    {
        if(drinkMaker.selectedCup.liquidAmountInCup <= (drinkMaker.selectedCup.maxLiquid))
        {
            isMoving = true;
            DrinkMaker.Instance.PourLiquid(ingredient, amountOZ);
        }
    }
}
