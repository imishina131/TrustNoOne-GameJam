using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterData", menuName = "Scriptable Objects/Monsters")]
public class MonsterData : ScriptableObject
{
    public GameObject monsterPrefab;
    public List<MonsterTraits> traits;
    
    //Monster specific traits
   [SerializeField] private float eyeGlow;
   [SerializeField] private bool sharpTeeth;
   [SerializeField] private float skinOpacity;
   [SerializeField] private bool pointyEars;
    
    public float EyeGlow => eyeGlow;
    public bool SharpTeeth => sharpTeeth;
    public float SkinOpacity => skinOpacity;
    public bool PointyEars => pointyEars;
    
    
    
}
