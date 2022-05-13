using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kosa : MonoBehaviour,IWorkable
{
    
        public bool isEnable = false;
        public GameObject player;
    public Vector3 distance;

        public void Working()
        {
            print("Я могу косить траву");
            isEnable = true;

        }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))

        {

            if (isEnable)
            {

                print($"начинаем работать {this.name}");
                SETPosition(player);
            }
        }
        
        if(Input.GetMouseButtonUp(0))
        {
            isEnable = false;
        }
        
    }

        public void OnTriggerEnter(Collider other)
        {
          if(other.attachedRigidbody.GetComponent<Player>()&&isEnable)
          {
            player = other.gameObject;
           
          }
        }

        public void SETPosition(GameObject player)
        {
        transform.position = player.transform.position;
        }


}


    

