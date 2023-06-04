using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnObject", menuName = "ScriptableObjects/SpawnObject", order = 1)]

public class SpawnScriptableObject : ScriptableObject
{
    [SerializeField] public GameObject Prefub;  
}
