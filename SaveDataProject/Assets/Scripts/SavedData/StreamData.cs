using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


namespace OOP
{
    public sealed class StreamData : IData<PlayerInfo>
    {
         public void Save(PlayerInfo data, string path=null)
         {
            if(path==null)
            { return; }

            using (var sw = new StreamWriter(path)) 
            {
                sw.WriteLine(data.NamePlayerQ);
                sw.WriteLine(data.PositionPlayer.X);
                sw.WriteLine(data.PositionPlayer.Y);
                sw.WriteLine(data.PositionPlayer.Z);
                sw.WriteLine(data.HelthQ);
                sw.WriteLine(data.PlayerScoreQ);

            }
            

         }

        public void SaveBonusData(BonusCurrentPositionInfo databonus, string path = null)
        {
            if (path == null)
            { return; }

            using (var sw = new StreamWriter(path))
            {
                
                sw.WriteLine(databonus.positionBonus.x);
                sw.WriteLine(databonus.positionBonus.y);
                sw.WriteLine(databonus.positionBonus.z);
                 

            }


        }


        public PlayerInfo Load(string path = null)
        {
            var resultForload = new PlayerInfo();

            using (var sr = new StreamReader(path))
            {
                // while (!sr.EndOfStream)


                resultForload.NamePlayerQ = sr.ReadLine();
                resultForload.PositionPlayer.X = sr.ReadLine().TrySingle();
                resultForload.PositionPlayer.Y = sr.ReadLine().TrySingle();
                resultForload.PositionPlayer.Z = sr.ReadLine().TrySingle();
                resultForload.HelthQ = sr.ReadLine().TryInt();
                resultForload.PlayerScoreQ = sr.ReadLine().TryInt();


            }

            return resultForload;
        }   
        
        //public BonusCurrentPositionInfo Load_Bonus(string path=null)
        //{
        //    var resultForloadBonus = new BonusCurrentPositionInfo();
        //    using (var srBonus = new StreamReader(path))
        //    {
        //        resultForloadBonus.positionBonus.x = srBonus.ReadLine().TrySingle();
        //        resultForloadBonus.positionBonus.y = srBonus.ReadLine().TrySingle();
        //        resultForloadBonus.positionBonus.z = srBonus.ReadLine().TrySingle();
        //    }

        //    return resultForloadBonus;

        //}
    }
}
