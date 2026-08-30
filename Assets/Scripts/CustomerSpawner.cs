using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    
    [SerializeField] private CustomerPreset[] customerSets;
    [SerializeField] private CustomerPreset[] monsterSets;
    
    
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCustomer()
    {
        int randomNumber = Random.Range(0, 101);
        
        if (randomNumber <= 45)
        {
            CustomerPreset monsterPreset = monsterSets[Random.Range(0, monsterSets.Length)];
            GameObject customer = Instantiate(
                monsterPreset.customerPrefab, transform.position,
                monsterPreset.customerPrefab.transform.rotation);
            customer.GetComponent<Customer>().InitializeCustomer(monsterPreset);
        }
        else
        {
            CustomerPreset normalCustomerPreset = customerSets[Random.Range(0, customerSets.Length)];
            GameObject customer = Instantiate(
                normalCustomerPreset.customerPrefab, transform.position,
                normalCustomerPreset.customerPrefab.transform.rotation);
            customer.GetComponent<Customer>().InitializeCustomer(normalCustomerPreset);
        }
    }
}
