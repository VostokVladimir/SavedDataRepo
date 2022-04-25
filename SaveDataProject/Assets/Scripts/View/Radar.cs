using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace OOP
{
    public class Radar : MonoBehaviour
    {
        [SerializeField]private Transform _playerPosition;
        private static List<RadarObject> listRadarObjects;
        private readonly float _mapScale = 1.5f;


           public void Awake()
           {
            listRadarObjects = new List<RadarObject>();
           }


        private void Start()
        {
            //_playerPosition = Camera.current.transform;
        }




        /// <summary>
        /// Метод для инициации обьектов на радаре и добавления их в список 
        /// </summary>
        /// <param name="gameObject"></param>
        /// <param name="iconObject"></param>
        public static void AddObjectToRadar(GameObject gameObject,Image iconObject)
        {
            Image image = Instantiate(iconObject);
            listRadarObjects.Add(new RadarObject{ radarObject = gameObject, Icon = iconObject });

        }

        /// <summary>
        /// Метод для удаления обьектов с радара
        /// </summary>
        /// <param name="gameObject"></param>
        public static void RemoveObjectFromRadar(GameObject gameObject)
        {
            List<RadarObject> SecondListRadarObjects = new List<RadarObject>();//создали альтернативный список обьектов радара
            foreach(RadarObject element in listRadarObjects) //перебираем обьекты первого списка 
            {
                if (element.radarObject==gameObject)//если удаляемый обьект найден удаляем его иконку
                {
                    Destroy(element.Icon);
                    continue;

                }

                SecondListRadarObjects.Add(element);//клонируем элементы не подлежащие удалению  во второй список обьектов на радаре
                
            }

              listRadarObjects.RemoveRange(0,listRadarObjects.Count);//удаляем все элементы диапозона от 0 до последнего индекса элемента  из 1 списка
              listRadarObjects.AddRange(SecondListRadarObjects);//копируем все неудаленные обьекты из списка 2 к список 1;

        }

        /// <summary>
        /// Метод синхронизирует значки на радаре с реальными обьектами
        /// </summary>
        private void DrawRadar()
        {
            foreach(RadarObject element in listRadarObjects)
            {
                Vector3 radarPosition = (element.radarObject.transform.position - _playerPosition.position);//не понятно
                float distPlayerToObject = Vector3.Distance(_playerPosition.position, element.radarObject.transform.position) * _mapScale; ;//растояние между игроком и обьектом в списке
                float delta = Mathf.Atan2(radarPosition.x, radarPosition.z) * Mathf.Rad2Deg - 270 - _playerPosition.eulerAngles.y;
                radarPosition.x = distPlayerToObject * Mathf.Cos(delta * Mathf.Deg2Rad) * -1;
                radarPosition.z= distPlayerToObject * Mathf.Cos(delta * Mathf.Deg2Rad);
                element.Icon.transform.SetParent(transform);//ВЫдает ошибку 
                element.Icon.transform.position = new Vector3(radarPosition.x, radarPosition.z, 0) + transform.position;


            }

        }

        private void Update()
        {
            if(Time.frameCount%2==0)
            {
                DrawRadar();
            }
        }



    }

    
        

    public sealed class RadarObject
        {
        public Image Icon;
        public GameObject radarObject;

        }

}
