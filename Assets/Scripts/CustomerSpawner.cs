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
   
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCustomer()
    {
        height = Random.Range(-1.45f, 1.13f);
        float monsterChance = Random.Range(0, 101);
        IDData idData = new IDData(eyeColors[Random.Range(0,eyeColors.Length)], 
            hairColors[Random.Range(0,hairColors.Length)], 
            skinColors[Random.Range(0,skinColors.Length)], names[Random.Range(0,names.Length)], height
        );

        TrueAppearanceData trueAppearanceData = new TrueAppearanceData(idData);
        
       GameObject customer = Instantiate(customerPrefab, transform.position, customerPrefab.transform.rotation);

        if (monsterChance <= 45f)
        { 
            trueAppearanceData.ApplyMonsterTraitOverrides(monsterDatas[0]);
            customer.GetComponent<Customer>().InitializeCustomer(idData,trueAppearanceData,monsterDatas[0]);
        }
        else
        {
            customer.GetComponent<Customer>().InitializeCustomer(idData,trueAppearanceData, null);
        }
        
       
    }
}
