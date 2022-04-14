using System;
using System.Collections.Generic;
using UnityEngine;


namespace QQQ

{
    public class Enemy:MonoBehaviour,IDamageableObj
    {
        private float _currenthealth;
        [SerializeField]public float maxhelth;

        public void Start()
        {
            _currenthealth=maxhelth;
        }

        public void ApplyDamage(int damage)
        {
            _currenthealth -= damage;
            Debug.Log("Враг крепкая у нее " + _currenthealth + "баллов");
            if (_currenthealth<=0)
            { Destroy(gameObject); }

        }
    }
}
