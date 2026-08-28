using UnityEngine;

public class Customer : MonoBehaviour
{
    [SerializeField] private bool _isMonster;

    public bool IsMonster => _isMonster;
    
    private IDData _idData;
    
    public IDData IDData => _idData;
    
    private TrueAppearanceData _appearanceData;
    
    public TrueAppearanceData AppearanceData => _appearanceData;

   
    
    
    
    public void InitializeCustomer(IDData idData, TrueAppearanceData appearanceData,  MonsterData monsterData)
    {
       _idData = idData;
       _appearanceData = appearanceData;
       _isMonster = monsterData != null;
       
    }
    


}
