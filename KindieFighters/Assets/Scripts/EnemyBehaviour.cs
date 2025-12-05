using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class EnemyBehaviour : MonoBehaviour
{
    private int maxhp;
    private int hp, atk, def;
    public TMP_Text displayHp;

    public void InitStat(int hpVal, int atkVal, int defVal)
    {
        maxhp = hpVal;
        hp = maxhp;
        atk = atkVal;
        def = defVal;
    }

    public int GetAtk()
    {
        return atk;
    }

    public void TakeDmg(int dmg)
    {
        hp = hp - dmg;
    }

    // Start is called before the first frame update
    void Start()
    {
        InitStat(40, 5, 2);
    }

    // Update is called once per frame
    void Update()
    {
        displayHp.text = hp.ToString();
    }
}
