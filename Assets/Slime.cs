using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour {

        public Text stateText;
        public GameObject player;
        Player playerScript;
    
        int a = 0;
        int achetime = 0;
        static public int m_stomach = 100; //포만감
        int m_level = 1; // 레벨에 따라서 스탯증가
        static public int m_health = 0; // 건강상태 1. 정상 2. 배탈 3. 감기
        static public int m_HP = 100; // 체력
        int m_attackPoint = 0; // 공격력(지금은 안씀)



        Slime(int stomach = 100, int level = 1, int health = 0, int HP = 100, int attackPoint = 0)
        {
            m_stomach = stomach;
            m_level = level;
            m_health = health;
            m_HP = HP;
            m_attackPoint = attackPoint;
        }


    private void Start()
    {

        playerScript = player.GetComponent<Player>();

    }

    private void Update()
        {
        
            if ()
            {
                hungry();
                ache();

            stateText.text = "money: " + Player.m_money + "                     HP: " + m_HP + "                        hurgry: " + m_stomach;
            //
            }
        }

    void Event()
        {

        }


        void hungry()
        {
            if (m_stomach > 0)
            {

            m_stomach--;
        }
            else if ((m_stomach < 20)&&(m_stomach>0))
            {
                m_HP--;
                m_stomach--;
                return;
            }
            else if (m_stomach <= 0)
            {
                m_HP = m_HP - 5;
            }
            return;
        }
        void ache()
        {
            switch(m_health)
            {
             case 0: break;
             case 1:
                Slime.m_HP = Slime.m_HP - 2;           //배탈
                Slime.m_stomach = Slime.m_stomach -3;
                    break;
             case 2: m_HP--;                    //감기
                    break;
             case 3: // 많이아픔
                    Slime.m_HP = m_HP - 3;
                    break;
             default: Debug.Log("slime_ache_Bug");
                    break;
            }

            if (m_health != 0)
            {
                achetime++;
                if (achetime > 5)
                {
                    achetime = 0;
                    m_health = 0;
                }
            }
        }

        void levelup()
        {
            m_level++;
        }

    public void testfood()
    {
        eat(1);
    }

        void eat (int food)
        {
            
            switch (food)
            {
                case 1:// 30프로 확률로 배탈 , 음식물 쓰레기
                if (playerScript.food0 > 0)
                { 
                    Debug.Log(Player.m_money);
                    Debug.Log(playerScript.food0);
                    playerScript.food0--;
                    Slime.m_HP = Slime.m_HP + 5;
                    m_stomach = Slime.m_stomach + 30;
                    if ((int)(Random.Range(0, 3) % 3) == 1) 
                    {
                        m_health = 1;
                    }
                }
                break;
                case 2://일반사료
                if (playerScript.food1 > 0)
                {
                    m_HP = m_HP + 5;
                    m_stomach = m_stomach + 20;
                    playerScript.food1--;
                }
                break;
            case 3: //고급사료
                if (playerScript.food2 > 0)
                {
                    playerScript.food2--;
                    m_HP = m_HP + 10;
                    m_stomach = m_stomach + 30;
                }
                break;
                case 4: // 포션
                if (playerScript.food3 > 0)
                {
                    m_HP = m_HP + 20;
                    playerScript.food3--;
                }
                break;
                default:
                    break;
            }
        if (m_HP > 100) { m_HP = 100; }
        if (m_stomach > 100) { m_stomach = 100; }


    }


}
