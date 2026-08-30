using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CustomerSpawner spawner;
    [SerializeField] private int totalCustomers = 5;
    private int _customersServed = 0;
    private Customer _currentCustomer;

    private void Start()
    {
        SetCurrentCustomer(spawner.SpawnCustomer());
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

    public void OnServerDrink(Cup cup)
    {
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
}
