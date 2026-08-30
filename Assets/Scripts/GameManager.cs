using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CustomerSpawner spawner;
    [SerializeField] private int totalCustomers = 5;
    private int _customersServed = 0;
    private Customer _currentCustomer;

    private Animator anim;

    [SerializeField] GameObject glass01;
    [SerializeField] GameObject glass02;
    [SerializeField] GameObject glass03;

    public DrinkMaker drinkMaker;

    private void Start()
    {
        //SetCurrentCustomer(spawner.SpawnCustomer());
        anim = GetComponent<Animator>();
    }
    public void SetCurrentCustomer(Customer customer)
    {
        _currentCustomer = customer;
    }

    public void OnBigRedButtonPressed()
    {
        if (_currentCustomer.IsMonster)
        {
            Debug.Log("Kicked out monster");
            NextCustomer();
        }
        else
        {
            Debug.Log("That was a person!");
            GameOver();
        }
    }

    public IEnumerator OnServerDrink(Cup cup)
    {
        yield return new WaitForSeconds(10);
        bool recipeCorrect = DrinkComparison.IsCorrectDrink(cup, _currentCustomer.Recipe);
        
        if (_currentCustomer.IsMonster)
        {
            Debug.Log("You served a monster!");
            GameOver();
        }
        else if (!recipeCorrect)
        {
            Debug.Log("Wrong recipe!");
            //Remake drink
        }
        else
        {
            Debug.Log("Correct recipe!");
            NextCustomer();
        }
        glass01.SetActive(false);
        glass02.SetActive(false);
        glass03.SetActive(false);

        DrinkMaker.Instance.selectedCup = null;

    }

    private void NextCustomer()
    {
        Destroy(_currentCustomer.gameObject);
        _customersServed++;

        if (_customersServed == totalCustomers)
        {
            WinGame();
            return;
        }
        _currentCustomer = spawner.SpawnCustomer();
        
    }

    private void GameOver()
    {
        Debug.Log("Game Over");
        
        //Load new scene
    }

    private void WinGame()
    {
        Debug.Log("Win Game");
        
        //Load new scene
    }

    public void Serve()
    {
        anim.SetTrigger("Make");
        StartCoroutine(OnServerDrink(drinkMaker.selectedCup));
    }
}
