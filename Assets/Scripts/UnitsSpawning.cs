using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsSpawning : MonoBehaviour
{
    [SerializeField] private Enemy _unit;
    [SerializeField] private float _delay = 2f;
    [SerializeField] private SpawnPoint[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(SpawnUnits());
    }

    private IEnumerator SpawnUnits()
    {
        yield return new WaitForSeconds(_delay);

        foreach (var spawnPoint in _spawnPoints)
        {
            Instantiate(_unit.Prefub.Prefub, spawnPoint.transform);
            yield return new WaitForSeconds(_delay);
        }
    }
}
