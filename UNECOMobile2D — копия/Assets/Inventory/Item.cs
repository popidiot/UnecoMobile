using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]

public class Item : ScriptableObject
{
    [Header("Базовые характеристики")]
    public string Name = " ";
    public string Description = "Описание предмета";
    public Sprite icon = null;
    public int id = 0;
    /*
[Header("Игровые характеристики")]
public int time;

[Header("Характеристики для торговли")]
public int Coin;
public int Gems;

public string PlayerPrefsName;
*/
}
