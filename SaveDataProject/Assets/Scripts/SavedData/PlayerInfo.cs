using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class PlayerInfo 
{ 
    
    //fields
    private float _helth;
    private string _namePlayer;
    private float _playerscore;
    public Vector3 playerPosition;

    //property
    public float _Helth 
    {
        get {return _helth;}
        set { _helth = value;}
        
    }

    public string _NamePlayer
    {
        get { return _namePlayer; }
        set { _namePlayer = value; }

    }

    public float _Playerscore
    {
        get { return _playerscore; }
        set { _playerscore = value; }

    }

    public override string ToString()
    {
        return $" Игрок имя {_NamePlayer} счет {_Playerscore} позиция {playerPosition} здоровье {_Helth} ";
    }


    //konstructor
    public PlayerInfo(string _namePlayer,float _helth,float _playerscore)
    {
        this._helth = _helth;
        this._namePlayer = _namePlayer;
        this._playerscore = _playerscore;

    }


}
