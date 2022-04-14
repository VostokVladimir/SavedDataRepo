using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace OOP
{   [Serializable]
    public sealed class SavedData
    {
        public string Name;
        public Vector3Seriallizable Position;
        public bool IsEnabled;

        public override string ToString()
        {
            return $"Имя {Name} Позиция {Position} Статус Активации {IsEnabled} ";
        }

    }
        [Serializable]

        public struct Vector3Seriallizable
        {
            public float x;
            public float y;
            public float z;


            public Vector3Seriallizable(float x,float y,float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;

            }

            public static implicit operator Vector3Seriallizable(Vector3 value) //имплисит неявное преобразование, эксплисит явное преобразование-то есть надо указывать тип данных в скобках преобразования 
            {
                return new Vector3Seriallizable(value.x, value.y, value.z);

            }

            public static implicit operator Vector3(Vector3Seriallizable value)
            {
                return new Vector3(value.x, value.y, value.z);
            }


        }

        


    
}
