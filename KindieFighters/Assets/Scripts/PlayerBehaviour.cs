using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class PlayerBehaviour : MonoBehaviour
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

    public void TakeDmg(int dmg)
    {
        hp = hp - dmg;
    }

    // Start is called before the first frame update
    void Start()
    {
        InitStat(50, 10, 5);
    }

    // Update is called once per frame
    void Update()
    {
        displayHp.text = hp.ToString();
    }
}
