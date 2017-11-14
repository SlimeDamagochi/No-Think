using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    int m_HP = 50;
    int m_attackPoint = 100;
    public static int m_money = 1000;
    public int money = 1000;
    // int* food = new int[4];
    public int food0 = 0;
    public int food1 = 0;
    public int food2 = 0;
    public int food3 = 0;

    Player(int HP = 50, int attckPoint = 100, int m_money = 1000)
    {
        m_HP = HP;
        m_attackPoint = attckPoint;
        m_money = money;
    }
}
