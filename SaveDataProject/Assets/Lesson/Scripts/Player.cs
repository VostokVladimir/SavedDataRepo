using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody _rigidbody;
    public GameObject go;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        speed = 5.0f;
    }


    public void Move()
    {
        float movehorizont = Input.GetAxis("Horizontal");
        float movevertikal = Input.GetAxis("Vertical");
        Vector3 movevector3 = new Vector3(movehorizont, 0, movevertikal);
        _rigidbody.velocity = movevector3 * speed;
    }

    private void Update()
    {
        Move();
        

    }

    private void OnTriggerEnter(Collider other)


    {


        if (other.attachedRigidbody)
        {


            if (other.attachedRigidbody.TryGetComponent(out ICollectable loot))
            {
                loot.Collect();
            }

            if (other.attachedRigidbody.TryGetComponent(out IWorkable tool))
            {
                tool.Working();
                 
                
                
            }
        }


    }

    
}
