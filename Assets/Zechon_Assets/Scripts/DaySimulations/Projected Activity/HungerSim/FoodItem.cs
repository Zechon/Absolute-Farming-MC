using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FoodItem
{
    public string name;
    public float hungerRestore;
    public float saturationRestore;

    public FoodItem(string name, float hungerRestore, float saturationRestore)
    {
        this.name = name;
        this.hungerRestore = hungerRestore;
        this.saturationRestore = saturationRestore;
    }
}
