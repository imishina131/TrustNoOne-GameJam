using UnityEngine;

public class Customer : MonoBehaviour
{
    private CustomerPreset _preset;
    
    public CustomerPreset Preset => _preset;
    
    private Recipe _recipe;
    
    public Recipe Recipe => _recipe;
    
    public bool IsMonster => _preset.isMonster;
    
    public void InitializeCustomer(CustomerPreset preset ,Recipe recipe)
    {
        _preset = preset;
        _recipe = recipe;
    }

   


}
