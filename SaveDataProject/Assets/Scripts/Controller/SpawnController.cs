using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject bonusPrefab;
    
    
    void Start()
    { 
        for(int i=0; i<=6; i++)
        {
          SpawningOnScene();
        }
        
    }

    public void SpawningOnScene()
    {
        Vector3 bonusposition = Vector3.zero;
        bonusposition.x = Random.Range(-4,4);
        bonusposition.z = Random.Range(-4, 4);
        bonusposition.y = Random.Range(1, 3);
        //transform.rotation = Quaternion.Euler(90, 0, 0);//Как префаб повернуть на  90 градусов ?
        Instantiate(bonusPrefab, bonusposition, Quaternion.identity,transform);
    }



}
