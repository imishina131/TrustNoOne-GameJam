using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomerData", menuName = "Scriptable Objects/CustomerPreset")]
public class CustomerPreset : ScriptableObject
{
    public GameObject customerPrefab;
    public Sprite customerID;
    public bool isMonster;
}
