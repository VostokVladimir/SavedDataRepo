﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace OOP
{   
    public class BonusCurrentPositionInfo : MonoBehaviour
    {
        
        public Vector3 positionBonus;


        private void Update()
        {

            positionBonus = transform.position;
        }




    }
}
