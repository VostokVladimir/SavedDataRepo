using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> item;//коллекция предметов
    public GameObject cellContainer;//эта ссылка будет заполнена обьектом - Panel из канваса содержащего ячейки рюкзака плеера
    public KeyCode showInventory;//эта клавиша которая будет запускать вызов инвентору панели рюкзака с содержимым
        // Start is called before the first frame update
    void Start()
    {
        item = new List<Item>();
        cellContainer.SetActive(false);
        for (int i=0; i<=cellContainer.transform.childCount;i++)//определяем колличество секций-ячеек на GO- InventoryPanel(все обьекты cell) на сцене через подсчет дочерних обьектов
        {
            item.Add(new Item());//заполняем коллекцию пустышками типа Item без содержания, что бы при удалении обьекта из рюкзака у нас ячейка оставалась пустой ,а не заполнялась новым элементом коллекции
        }
    }

    // Update is called once per frame
    void Update()
    {
        ToggleInventory();
    }

    void ToggleInventory()
    {
       if(Input.GetKeyDown(showInventory))
       {
            if(cellContainer.activeSelf)//если GO-рюкзак на сцене активен
            {
                cellContainer.SetActive(false);// то мы дизактивируем убираем этот рюкзак
            }
            else
            {
                cellContainer.SetActive(true);// то мы  активируем рюкзак при нажатии одной кнопки
            }
        }

    }
}
