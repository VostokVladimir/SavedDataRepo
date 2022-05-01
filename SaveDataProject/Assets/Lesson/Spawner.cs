using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Sphere _spherePrefab;
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
        position.x = Random.Range(-10, 10);
        position.z = Random.Range(-10, 10);
        Instantiate(_spherePrefab, position, Quaternion.identity, transform).Init(_player);
    }
}
