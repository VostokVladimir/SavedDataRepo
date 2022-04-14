using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


namespace OOP
{
    public sealed class StreamData : IData<SavedData>
    {
         public void Save(SavedData data, string path=null)
         {
            if(path==null)
            { return; }

            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(data.Name);
                sw.WriteLine(data.Position.x);
                sw.WriteLine(data.Position.y);
                sw.WriteLine(data.Position.z);
                sw.WriteLine(data.IsEnabled);
            
            
            }

         }

        public SavedData Load(string path = null)
        {
            var resultForload = new SavedData();

            using (var sr=new StreamReader(path))
            {
                
                resultForload.Name = sr.ReadLine();
                //resultForload.Position.x = sr.ReadLine().TrySingle();
                //resultForload.Position.y = sr.ReadLine().TrySingle();
                //resultForload.Position.z = sr.ReadLine().TrySingle();
                //resultForload.IsEnabled = sr.ReadLine().TryBool();


            }

            return resultForload;
        }        
    }
}
