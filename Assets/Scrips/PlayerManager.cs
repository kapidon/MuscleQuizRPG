using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerManager : MonoBehaviour
{
    public int hp;
    public int at;


    public void Damage()
    {
        hp -= 1;

        if (hp <= 0)
        {
            hp = 0;
        }
    }
}
