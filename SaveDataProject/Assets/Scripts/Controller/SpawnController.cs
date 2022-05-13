using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP
{
    public class SpawnController : MonoBehaviour
    {
        [SerializeField] private GameObject bonusPrefab;


        void Start()
        {
            for (int i = 0; i <= 6; i++)
            {
                SpawningOnScene();
            }

        }

        public void SpawningOnScene()
        {
            Vector3 bonusposition = Vector3.zero;
            bonusposition.x = Random.Range(-4, 4);
            bonusposition.z = Random.Range(-4, 4);
            bonusposition.y = Random.Range(1, 3);
            Instantiate(bonusPrefab, bonusposition, bonusPrefab.transform.rotation, transform);
        }

        public void SpawningOnSceneLoad(DataBonusPosition[] value)
        {
            for (int i = 0; i <= value.Length; i++)
            {
                Vector3 bonusposition = Vector3.zero;

               // bonusposition.x = value[i].
               // bonusposition.z = ;
              //  bonusposition.y =;
                Instantiate(bonusPrefab, bonusposition, bonusPrefab.transform.rotation, transform);
            }
        }


    }
}
