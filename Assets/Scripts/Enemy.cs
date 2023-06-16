using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;

    public GameObject GetPrefab()
    {
        return Prefab;
    }
}
