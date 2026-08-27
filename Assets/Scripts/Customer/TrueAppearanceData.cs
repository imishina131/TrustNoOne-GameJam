using UnityEngine;

public class TrueAppearanceData 
{
   
   private Color _eyeColor;
   private Color _hairColor;
   private Color _skinColor;
   private string _customerName;
   private int _customerHeight;
   
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

   public void ApplyMonsterTraitOverrides(float skinOpacity =1f, float eyeGlow = 0f, bool sharpTeeth = false, bool pointyEars = false)
   {
     //for loop through contents of monster SO and if matching trait parameter override it here
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

   public int CustomerHeight
   {
      get { return _customerHeight; }
   }
   
   //Monster traits
   public float EyeGlow
   {
      get { return _eyeGlow; }
      set { _eyeGlow = value; }
   }
   
   public bool SharpTeeth
   {
      get { return _sharpTeeth; }
      set { _sharpTeeth = value; }
   }
   public float SkinOpacity
   {
      get { return _skinOpacity; }
      set { _skinOpacity = value; }
   }
   public bool PointyEars
   {
      get { return _pointyEars; }
      set { _pointyEars = value; }
   }
}
