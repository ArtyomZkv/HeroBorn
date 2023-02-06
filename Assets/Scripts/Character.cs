using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    #region Fields
    public string name = "Not assgned";
    public int exp = 0;
    #endregion

    #region Properties

    private string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    private int Exp
    {
        get
        {
            return exp;
        }
        set
        {
            exp = value;
        }
    }

    #endregion

    #region Constructors

    public Character(string name, int exp)
    {
        Name = name;
        Exp = exp;
    }
    public Character()
    {
        Name = "Not assigned";
        Exp = default;
    }
    public Character(string name)
    {
        Name = name;
        Exp = default;
    }

    #endregion

    #region Methods

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", Name, Exp);
    }
    private void Reset()
    {
        Name = "Not assigned";
        Exp = 0;
    }
    #endregion
}
public struct Weapon
{
    #region Fields
    public string name;
    public int damage;
    #endregion

    #region Properties

    private string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    private int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }

    #endregion

    #region Constructors

    public Weapon(string name, int damage) : this()
    {
        Name = name;
        Damage = damage;
    }

    #endregion

    #region Methods
    public void PrintWeaponsStats()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMG", Name, Damage);
    }
    #endregion
}

