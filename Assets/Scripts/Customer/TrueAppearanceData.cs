using UnityEngine;

public class TrueAppearanceData 
{
   
   private Color _eyeColor;
   private Color _hairColor;
   private Color _skinColor;
   private string _customerName;
   private float _customerHeight;
   
   //Monster specific traits
   private float _eyeGlow;
   private bool _sharpTeeth;
   private float _skinOpacity;
   private bool _pointyEars;


   public TrueAppearanceData(IDData customerIDInfo)
   {
      _eyeColor = customerIDInfo.EyeColor;
      _hairColor = customerIDInfo.HairColor;
      _skinColor = customerIDInfo.SkinColor;
      _customerName = customerIDInfo.CustomerName;
      _customerHeight = customerIDInfo.CustomerHeight;
      _skinOpacity = 1.0f;
      
   }

   public void ApplyMonsterTraitOverrides(MonsterData monsterData)
   {
     foreach(var trait in monsterData.traits)
     {
        switch (trait)
        {
           case MonsterTraits.EyeGlow:
            _eyeGlow = monsterData.EyeGlow;
              break;
           case MonsterTraits.SharpTeeth:
            _sharpTeeth = monsterData.SharpTeeth;
              break;
           case MonsterTraits.SkinOpacity:
              _skinOpacity = monsterData.SkinOpacity;
              break;
           case MonsterTraits.PointyEars:
              _pointyEars = monsterData.PointyEars;
              break;
           default:
              Debug.LogError("Unknown monster trait: " + trait);
              break;
              
        }
     }
   }
   
   //Human traits
   public Color EyeColor
   {
      get { return _eyeColor; }
   }

   public Color HairColor
   {
      get { return _hairColor; }
   }

   public Color SkinColor
   {
      get { return _skinColor; }
   }

   public string CustomerName
   {
      get { return _customerName; }
   }

   public float CustomerHeight
   {
      get { return _customerHeight; }
   }
   
   //Monster traits
   public float EyeGlow
   {
      get { return _eyeGlow; }
   }
   
   public bool SharpTeeth
   {
      get { return _sharpTeeth; }
   }
   public float SkinOpacity
   {
      get { return _skinOpacity; }
   }
   public bool PointyEars
   {
      get { return _pointyEars; }
   }
}
