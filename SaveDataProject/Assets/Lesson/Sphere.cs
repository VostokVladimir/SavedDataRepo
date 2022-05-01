using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private GameObject _player;

    public void Init(GameObject player)
    {
        _player = player;
    }
}
