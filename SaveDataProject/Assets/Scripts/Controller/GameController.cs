using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP
{
    public class GameController : MonoBehaviour
    {
        private IData<SavedData> _dataforSave;





        // Start is called before the first frame update
        void Start()
        {


            var saved = new SavedData();
            var streamData = new StreamData();
            saved.Name = "Player";
            saved.Position.x = transform.position.x;
            saved.Position.y = transform.position.y;
            saved.Position.z = transform.position.z;
            saved.IsEnabled = true;
            streamData.Save(saved, "C:/Users/HP VICTUS/Desktop/GeekBrains/Курс 4 Основы С# в Unity/Урок 8 Сохранение данных/savedData2.txt");

        }


    }
}
