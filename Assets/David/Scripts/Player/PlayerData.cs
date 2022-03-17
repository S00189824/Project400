using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string name;
    public float health;
    public int level;

    public PlayerData(string name, float health, int level)
    {
        this.name = name;
        this.health = health;
        this.level = level;

        
    }

    public override string ToString()
    {
        return $"{name} is at {health} HP. Your level is {level}"; 
    }
}
