using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Axe : MonoBehaviour,IWorkable
{ 
    public bool isEnable=false;

    public void Working()
    {
        print("Я могу нарубить дров");

    }

}
