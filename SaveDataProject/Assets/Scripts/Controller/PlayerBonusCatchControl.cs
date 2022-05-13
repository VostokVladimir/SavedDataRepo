using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace OOP
{
    public class PlayerBonusCatchControl : MonoBehaviour
    {
        
        public PlayerInfo playerInfo;
        public delegate PlayerInfo MyDelegate (PlayerInfo player);
        public event MyDelegate _greatePlayerevent;
        public Text textScore;
       
      



        public void Start()
        {
            playerInfo = new PlayerInfo();

            playerInfo.NamePlayerQ = "Коля";
            playerInfo.PositionPlayer = transform.position;
            playerInfo.PlayerScoreQ = 1;
            playerInfo.PositionPlayer.X = transform.position.x;
            playerInfo.PositionPlayer.Y = transform.position.y;
            playerInfo.PositionPlayer.Z = transform.position.z;
            //задаем стартовую позицию игрока
            Debug.Log($"позиция на старте X {playerInfo.PositionPlayer.X} Y {playerInfo.PositionPlayer.Y} Z {playerInfo.PositionPlayer.Z}");
           
            
            if(playerInfo!=null)
            {
                _greatePlayerevent?.Invoke(playerInfo);
                Debug.Log("создан экземпляр игрока");
            }

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
            if (other.gameObject.CompareTag("Bonus"))

            {

                var _goodbonus = other.GetComponent<GoodBonus>();
                var bonus = _goodbonus.Point;//получаем размер очков от сбора Бонуса
                playerInfo.PlayerScoreQ += bonus;
                textScore.text = playerInfo.PlayerScoreQ.ToString();//выводим счет очков на канвас через инспектор пробрасывая ссылку
                
            }
        }

    }
}
