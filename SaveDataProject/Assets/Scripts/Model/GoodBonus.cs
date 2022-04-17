using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoodBonus : MonoBehaviour, IFlay
{
    public int Point;
    private float _lenthflay;
   // public References references; //не спаунится ссылка блин
    //public GameObject _goodBonus;
   // public Vector3 _goodspawn1;


    void Awake()
    {

       _lenthflay = Random.Range(2f,2.2f);
        
               
    }

    void Start()
    {
        
        
        //Instantiate(references.GoodBonus, new Vector3(1, 1, 1), Quaternion.identity);
        //Instantiate(_goodBonus, _goodspawn1, Quaternion.identity);
      //
    }

    void Update()
    {
        
        transform.Rotate(0.0f, 0.0f, 0.5f);
        Flay();
    }

    public void Flay()
    {
         
        transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lenthflay));
        
    }


}
