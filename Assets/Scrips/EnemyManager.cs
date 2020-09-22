using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
    
{
    
    public int hp;
    public int at;

    public void Attack(PlayerManager player)
    {
        player.Damage();
    }
    public void Damage()
    {
        hp -= 1;
        if (hp <= 0)
        {
            hp = 0;
        }
    }
}
