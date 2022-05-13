using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _vegetablePrefab;
    private void Start()
    {
        int randomCount = Random.Range(3, 12);
        for (int i = 0; i < randomCount; i++)
        {
            Spawn();
        }


    }
    private void Spawn()
    {
        Vector3 position = Vector3.zero;
        position.x = Random.Range(-6, 6);
        position.z = Random.Range(-6, 6);
        Instantiate(_vegetablePrefab, position, Quaternion.identity, transform);
    }
}
