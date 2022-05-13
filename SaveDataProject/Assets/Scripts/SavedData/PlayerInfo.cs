using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace OOP
{
    [Serializable]
    public class PlayerInfo
    {

        //fields
        public float HelthQ;
        public string NamePlayerQ;
        public float PlayerScoreQ;
        // public Vector3 playerPosition;
        public Vector3Serializable PositionPlayer;

        //property
        
               

        //public float _Playerscore//свойства не получают данные полей класса и остаются дефолтными
        //{
        //    get { return _playerscore; }
        //    set 
        //    { 
        //        _playerscore = value;
        //       
        //    }


        //}

        public override string ToString()
        {
            return $" Игрок имя {NamePlayerQ} счет {PlayerScoreQ} позиция {PositionPlayer} здоровье {HelthQ} ";
        }


        
    }

    [Serializable]

    public struct Vector3Serializable
    {
        public float X;
        public float Y;
        public float Z;

        private Vector3Serializable(float Xx, float Yy, float Zz )

        {
            X = Xx;
            Y = Yy;
            Z = Zz;

        }

        public static implicit operator Vector3(Vector3Serializable value)
        {
            return new Vector3(value.X, value.Y, value.Z);
        }
        public static implicit operator Vector3Serializable(Vector3 value)
        {
            return new Vector3Serializable(value.x, value.y, value.z);
        }
        public override string ToString() => $" (X = {X} Y = {Y} Z = {Z})";




    }



}
