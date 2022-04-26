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
        private float _helth;
        private string _namePlayer;
        private float _playerscore;
        // public Vector3 playerPosition;
        public Vector3Serializable PositionPlayer;

        //property
        public float _Helth
        {
            get { return _helth; }
            set { _helth = value; }

        }

        public string _NamePlayer
        {
            get { return _namePlayer; }
            set { _namePlayer = value; }

        }

        public float _Playerscore
        {
            get { return _playerscore; }
            set { _playerscore = value; }

        }

        public override string ToString()
        {
            return $" Игрок имя {_NamePlayer} счет {_Playerscore} позиция {PositionPlayer} здоровье {_Helth} ";
        }


        ////konstructor
        //public PlayerInfo(string _namePlayer, float _helth, float _playerscore,Vector3Serializable position)
        //{
        //    this._helth = _helth;
        //    this._namePlayer = _namePlayer;
        //    this._playerscore = _playerscore;
        //    this.PositionPlayer = position;

        //}


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
