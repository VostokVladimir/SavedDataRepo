using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace OOP
{
    public class GameController : MonoBehaviour
    {
        //private IData<SavedData> _dataforSave;
        private References references;
        public PlayerInfo playerInfo;
        public float score;
        public SaveGame game;
        public PlayerInfo currentplayerInfo;
        
         

        public void Awake()


        {
            playerInfo = new PlayerInfo("Вася",20,0);
            playerInfo.playerPosition = transform.position;//задаем стартовую позицию игрока
            Debug.Log($"позиция на старте X {playerInfo.playerPosition.x} Y {playerInfo.playerPosition.x} Z {playerInfo.playerPosition.z}");//проблема 1 почему выводит в дебаг  два варианта значения позиции объекта ? ( см принт скрин)
            score = playerInfo._Playerscore;//задаем счет игрока  на старте игры

            #region "Работа с ссылками"
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
            #endregion

                      
            
        }

        public void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Bonus"))

            {
                
             var _goodbonus= other.GetComponent<GoodBonus>();
             var bonus= _goodbonus.Point;//получаем размер очков от сбора Бонуса
             playerInfo._Playerscore += bonus;
             Debug.Log($" стало {playerInfo._Playerscore}");
            }
        }

       

        void Update()
        {
            if (playerInfo != null)//передаем текущие данные Игрока
            {
               // currentplayerInfo = playerInfo;
                currentplayerInfo._NamePlayer = playerInfo._NamePlayer;
               currentplayerInfo._Playerscore = playerInfo._Playerscore;
                currentplayerInfo.playerPosition = playerInfo.playerPosition;
            }

            Debug.Log($"из апдейта счет  {currentplayerInfo._Playerscore}");// Проблема 2 почему в дебаге два значения 0 и обновленное ?
        }


        public void Save()//на данном методе кнопка Save на канвасе. 
        {
            if (game == null)
            { game = new SaveGame(playerInfo); }
            else 
            { 
              game.SaveGameonButton(playerInfo);
              
             
            }

             Debug.Log($"счет игрока составляет { playerInfo}");//проблема3  почему при нажатии кнопки в дебаге выводит значение 0 при увеличении количества бонусов, и не делает обновление значения ?
        }

    }
}
