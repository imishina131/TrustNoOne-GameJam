using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject customerPrefab;
    [SerializeField] private MonsterData[] monsterDatas;
    [SerializeField] private Color[] hairColors;
    [SerializeField] private Color[] eyeColors;
    [SerializeField] private Color[] skinColors;
    [SerializeField] private string[] names;

    private float height;
    
    private GameObject _customer;
    void Start()
    {
       _customer = Instantiate(customerPrefab, transform.position, customerPrefab.transform.rotation);
       //_customer.GetComponent<Customer>().InitializeCustomer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCustomer()
    {
        height = Random.Range(-1.45f, 1.13f);
        float monsterChance = Random.Range(0, 1f);
        IDData idData = new IDData(eyeColors[Random.Range(0,eyeColors.Length)], 
            hairColors[Random.Range(0,hairColors.Length)], 
            skinColors[Random.Range(0,skinColors.Length)], names[Random.Range(0,names.Length)], height
        );

        TrueAppearanceData trueAppearanceData = new TrueAppearanceData(idData);

        if (monsterChance >= .45f)
        {
            trueAppearanceData.ApplyMonsterTraitOverrides(monsterDatas[0]);
            
        }
        
    }
}
