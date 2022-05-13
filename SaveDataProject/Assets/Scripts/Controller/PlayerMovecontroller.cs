using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovecontroller : MonoBehaviour
{
    public float speed;
    private Rigidbody _rigidbody;

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
        //_rigidbody.AddForce(movevector3 * speed);
        _rigidbody.velocity = movevector3 * speed;
    }

    private void Update()
    {
        Move();
    }

}
