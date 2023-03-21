using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUnits : MonoBehaviour
{
    [SerializeField] private GameObject _parentPoint;
    [SerializeField] private GameObject _unit;
    [SerializeField] private float _spawnTime = 2f;

    private float _timer;
    private int _childrenSpawnPointNumber = 0;
    private GameObject[] _spawnPointsArray;

    private void Start()
    {
        _spawnPointsArray = new GameObject[_parentPoint.transform.childCount];
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_childrenSpawnPointNumber <= _parentPoint.transform.childCount && _timer >= _spawnTime)
        {
            _spawnPointsArray[_childrenSpawnPointNumber] = _parentPoint.transform.GetChild(_childrenSpawnPointNumber).gameObject;

            _spawnPointsArray[_childrenSpawnPointNumber] = Instantiate(_unit, _spawnPointsArray[_childrenSpawnPointNumber].transform);

            _timer -= _spawnTime;

            _childrenSpawnPointNumber++;          
        }
    }
}
