using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnPoints;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {

        Instantiate(_template, _spawnPoints.position, Quaternion.identity);
       
    }
}
