using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    
    [SerializeField] private CustomerPreset[] customerSets;
    [SerializeField] private CustomerPreset[] monsterSets;
    [SerializeField] private Recipe[] normalRecipes;
    [SerializeField] private Recipe[] monsterRecipes;

    public Customer SpawnCustomer()
    {
        int randomNumber = Random.Range(0, 101);
        GameObject customer;
        
        if (randomNumber <= 45)
        {
            CustomerPreset monsterPreset = monsterSets[Random.Range(0, monsterSets.Length)];
             customer = Instantiate(
                monsterPreset.customerPrefab, transform.position,
                monsterPreset.customerPrefab.transform.rotation);
            customer.GetComponent<Customer>().InitializeCustomer(monsterPreset, monsterRecipes[Random.Range(0,monsterRecipes.Length)]);
        }
        else
        {
            CustomerPreset normalCustomerPreset = customerSets[Random.Range(0, customerSets.Length)];
             customer = Instantiate(
                normalCustomerPreset.customerPrefab, transform.position,
                normalCustomerPreset.customerPrefab.transform.rotation);
            customer.GetComponent<Customer>().InitializeCustomer(normalCustomerPreset, normalRecipes[Random.Range(0,normalRecipes.Length)]);
        }
        return customer.GetComponent<Customer>();
    }
}
