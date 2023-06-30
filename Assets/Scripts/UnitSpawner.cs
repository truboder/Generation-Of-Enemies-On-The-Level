using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
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
        var waiting = new WaitForSeconds(_delay);

        yield return waiting;

        foreach (var spawnPoint in _spawnPoints)
        {
            Instantiate(_unit.gameObject, spawnPoint.transform);
            yield return waiting;
        }
    }
}
