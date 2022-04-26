using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace OOP
{
    [Serializable]
    public class BonusInfo
    {

        //fields

        private string _nameBonus;
        public Vector3 _bonusPosition;

        //property


        public string _NameBonus
        {
            get { return _nameBonus; }
            set { _nameBonus = value; }

        }


        //konstructor
        public BonusInfo(string _nameBonus, Vector3 _bonusPosition)
        {

            this._nameBonus = _nameBonus;
            this._bonusPosition = _bonusPosition;

        }


    }
}
