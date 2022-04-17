using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP
{
    public class GameController : MonoBehaviour
    {
        private IData<SavedData> _dataforSave;
        private References references;
        private GameObject playerGO;
        private PlayerInfo playerInfo;
         

        private void Awake()


        {
            //вар 1
            // GameObject playerGO = null; //GO обнуляем что бы скачать префаб с папки ресурсес
            // references = new References();//создаем экз класса для хранения ссылок на папку//
            // playerGO = references.Player;//блин говорит что ссылка пустая референсес не загрузился
            //вар 2
            //var _playerGO = Resources.Load<GameObject>("Player"); //дал прямую ссылку 
            //Object.Instantiate(_player, new Vector3(2, 4, 2), Quaternion.identity);//грузится куча клонов префабов и юнити вылетает
            //забить пока на загрузку из папки

            //var player = new Player("Федор",20,0);

            //playerInfo = new PlayerInfo("Lena", 34, 0);
           // var name1 = playerInfo._NamePlayer;
            
            
        }


        // Start is called before the first frame update
        void Start()
        {

            
            var saved = new PlayerInfo("Lena", 34, 0);
            var streamData = new StreamData();
            saved._NamePlayer = "Player";
            Debug.Log($"Сейчас играет {saved._NamePlayer}");

            saved.playerPosition.x = transform.position.x;
            saved.playerPosition.y = transform.position.y;
            saved.playerPosition.z = transform.position.z;
            saved._Helth = 20;
            saved._Playerscore = 0;
            Debug.Log($"Сейчас играет {saved._Playerscore}");
            streamData.Save(saved, "C:/Users/HP VICTUS/Desktop/GeekBrains/Курс 4 Основы С# в Unity/Урок 8 Сохранение данных/savedData3.txt");

        }


        public void GetCurrentPlayerInfo()
        {
            playerInfo._Helth=56;
            playerInfo.playerPosition = transform.position;

        }


        private void Update()
        {
            

        }

    }
}
