using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMenu : MonoBehaviour
{
    private Enemy enemy;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        enemy = GameObject.Find("Enemy").GetComponent<enemy>();
    }

    public void OnAttackButtonClick()
    {
        enemy.TakeDmg(player.GetAtk());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
