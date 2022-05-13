using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine;


namespace Assets.Lesson.Model
{
    class Vegebatle: MonoBehaviour, ICollectable
    {
       
       public void  Collect()
        {
            string str= "Я овощ меня можно сьесть";
            var canvas=FindObjectOfType<Canvas>();
            var text=canvas.GetComponentInChildren<Text>();
            text.text = str;
            Invoke("ClearText", 3f);

        }


        public void ClearText()
        {
            var canvas = FindObjectOfType<Canvas>();
            var text = canvas.GetComponentInChildren<Text>();
            text.text = "";
        }
    }
}
