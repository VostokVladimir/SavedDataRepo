using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP
{
    public class GameController : MonoBehaviour
    {
        //private IData<SavedData> _dataforSave;
        private References references;
        private GameObject playerGO;
        public PlayerInfo playerInfo;
        public float score;
        
         

        private void Awake()


        {
            PlayerInfo playerInfo = new PlayerInfo("Вася",20,0);
            Debug.Log($"{playerInfo._NamePlayer}");
            playerInfo.playerPosition = transform.position;
            score = playerInfo._Playerscore;

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
             var bonus= _goodbonus.Point;
             ApplyGoodBonus(bonus);
               
            }
        }

               
        public void ApplyGoodBonus(float _bonus)
        {
            score = score + _bonus;
            playerInfo._Playerscore = score;
            Debug.Log($"было {score} получено {_bonus} балов  стало {score}");
        }



        public void SaveGameMethod(PlayerInfo playerInfo)
        {

            SaveGame game = new SaveGame();
            game.SaveGameonButton(playerInfo);


            

        }

    }
}
