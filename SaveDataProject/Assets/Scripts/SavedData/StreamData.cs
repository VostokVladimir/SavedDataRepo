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
                sw.WriteLine(data.playerPosition.x);
                sw.WriteLine(data.playerPosition.y);
                sw.WriteLine(data.playerPosition.z);
                sw.WriteLine(data._Helth);
                sw.WriteLine(data._Playerscore);

            }
            

         }

        public PlayerInfo Load(string path = null)
        {
            var resultForload = new PlayerInfo("",0,0);

            //if(path==null)
            //{ throw new NullReferenceException(); }

            //if(!File.Exists(path))
            //{ throw new FileNotFoundException("Файла загрузки нет в папке"); }


            using (var sr = new StreamReader(path))
            {
                // while (!sr.EndOfStream)


                resultForload._NamePlayer = sr.ReadLine();
                resultForload.playerPosition.x = sr.ReadLine().TrySingle();
                resultForload.playerPosition.y = sr.ReadLine().TrySingle();
                resultForload.playerPosition.z = sr.ReadLine().TrySingle();
                resultForload._Helth = sr.ReadLine().TryInt();
                resultForload._Playerscore = sr.ReadLine().TryInt();


            }

            return resultForload;
        }        
    }
}
