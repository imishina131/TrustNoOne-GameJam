using UnityEngine;

public class Customer : MonoBehaviour
{
    private CustomerPreset _preset;
    
    public CustomerPreset Preset => _preset;
    
    public bool IsMonster => _preset.isMonster;
    
    public void InitializeCustomer(CustomerPreset preset)
    {
        _preset = _preset;
    }

   


}
