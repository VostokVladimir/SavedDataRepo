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
                sw.WriteLine(data._NamePlayer);
                sw.WriteLine(data.PositionPlayer.X);
                sw.WriteLine(data.PositionPlayer.Y);
                sw.WriteLine(data.PositionPlayer.Z);
                sw.WriteLine(data._Helth);
                sw.WriteLine(data._Playerscore);

            }
            

         }

        public PlayerInfo Load(string path = null)
        {
            var resultForload = new PlayerInfo();

            using (var sr = new StreamReader(path))
            {
                // while (!sr.EndOfStream)


                resultForload._NamePlayer = sr.ReadLine();
                resultForload.PositionPlayer.X = sr.ReadLine().TrySingle();
                resultForload.PositionPlayer.Y = sr.ReadLine().TrySingle();
                resultForload.PositionPlayer.Z = sr.ReadLine().TrySingle();
                resultForload._Helth = sr.ReadLine().TryInt();
                resultForload._Playerscore = sr.ReadLine().TryInt();


            }

            return resultForload;
        }        
    }
}
