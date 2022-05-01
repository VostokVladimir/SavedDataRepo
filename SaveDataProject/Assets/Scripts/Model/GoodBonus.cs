using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP
{
    public class GoodBonus : MonoBehaviour, IFlay
    {
        public int Point;
        private float _lenthflay;
        private float _bonusPoint;//колличество балов при сборе;
        public delegate void GoodBonusDelegate(float a);
        public event GoodBonusDelegate Contact;
       

        // public References references; //не спаунится ссылка блин
        //public GameObject _goodBonus;
        // public Vector3 _goodspawn1;


        void Awake()
        {

            _lenthflay = Random.Range(3f, 4f);
           


        }

       

        public void Update()
        {

            transform.Rotate(0.5f, 0.0f, 0.0f);
            Flay();
        }

        public void Flay()
        {

            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lenthflay));

        }

        public void OnTriggerEnter(Collider other)//процесс
        {
            if (other.gameObject.CompareTag("Player"))
                        
            {   
                Destroy(gameObject);
            }
        }

       

        



}
}
