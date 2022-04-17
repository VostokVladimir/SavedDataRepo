using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class References 
{
    private Canvas _canvas;
    private GameObject _player=null;
    private GameObject _goodbonus;


    public Canvas _Canvas
    {
        get 
        {   if(_canvas==null)
            { _canvas = Object.FindObjectOfType<Canvas>(); }
            return _canvas;
        }

    }

    public GameObject Player
    {
        get 
        { if(_player==null)
            {
                var _player = Resources.Load < GameObject > ("Player");//вгрузили ссылку на префаб
            }

            return _player;
        
        }

    }

    public GameObject GoodBonus 
    {
        get
        {
            if (_goodbonus == null)
            {

                var gameObject = Resources.Load<GameObject>("GoodBonus");
                _goodbonus = Object.Instantiate(gameObject);


            }

            return _goodbonus;      
        }

       

    }



}
