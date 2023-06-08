using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]

public class Item : ScriptableObject
{
    [Header("������� ��������������")]
    public string Name = " ";
    public string Description = "�������� ��������";
    public Sprite icon = null;
    public int id = 0;
    /*
[Header("������� ��������������")]
public int time;

[Header("�������������� ��� ��������")]
public int Coin;
public int Gems;

public string PlayerPrefsName;
*/
}
