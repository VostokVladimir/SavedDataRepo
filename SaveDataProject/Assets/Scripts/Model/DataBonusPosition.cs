using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace OOP
{   /// <summary>
/// Струкутура создана для сохранения нескольких позиций класса BonusCurrentPositionInfo в строку JSON
/// </summary>
    [Serializable]
   

    public struct DataBonusPosition
    { 
        public Vector3[] v3s;
        public DataBonusPosition(BonusCurrentPositionInfo[] bonusCurrentPositionInfos)
        {
            v3s = new Vector3[bonusCurrentPositionInfos.Length];
            for (int i = 0; i < bonusCurrentPositionInfos.Length; i++)
            {
                v3s[i] = bonusCurrentPositionInfos[i].positionBonus;
            }
        }

    }
}
