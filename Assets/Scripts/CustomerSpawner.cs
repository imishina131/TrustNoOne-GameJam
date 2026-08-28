using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject customerPrefab;
    void Start()
    {
        Instantiate(customerPrefab, transform.position, customerPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
