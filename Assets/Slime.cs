using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{

    public Text stateText;
    public Player player;
    SlimePooController slimePoo;

    public int m_stomach = 100; //포만감
    public int m_health = 0; // 건강상태 1. 정상 2. 배탈 3. 감기
    public int m_HP = 100; // 체력
    public int foodNum = 0; // 먹은 음식 숫자
    int m_level = 1; // 레벨에 따라서 스탯증가
    int m_attackPoint = 0; // 공격력(지금은 안씀)

    float nextTime = 60;
    int achetime = 0;

    private void Awake()
    {
        initiate(); 
    }

    void initiate()
    {
        m_stomach = PlayerPrefs.GetInt("stomach", 100);
        m_level = PlayerPrefs.GetInt("level", 1);
        m_health = PlayerPrefs.GetInt("health", 0);
        m_HP = PlayerPrefs.GetInt("HP", 100);
        m_attackPoint = PlayerPrefs.GetInt("attackPoint", 0);
        foodNum = PlayerPrefs.GetInt("foodnum", 0);
    }

    private void Start()
    {
        stateText.text = " money: " + player.playerMoney + "\n HP: " + m_HP + "\n hurgry: " + m_stomach;
    }

    private void Update()
    {
        if (false) // 임시.
        {
            hungry();
            ache();

            stateText.text = "money: " + player.playerMoney + "\n HP: " + m_HP + "\n hurgry: " + m_stomach;
            //
        }

        if (Time.time >= nextTime)
        {
            nextTime = Time.time + nextTime;
            Poo();
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
            PlayerPrefs.SetInt("stomach", m_stomach);
            PlayerPrefs.Save();
        }
        else if ((m_stomach < 20) && (m_stomach > 0))
        {
            m_HP--;
            m_stomach--;
            PlayerPrefs.SetInt("HP", m_HP);
            PlayerPrefs.SetInt("stomach", m_stomach);
            PlayerPrefs.Save();
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
        switch (m_health)
        {
            case 0: break;
            case 1:
                m_HP = m_HP - 2;           //배탈
                m_stomach = m_stomach - 3;
                break;
            case 2:
                m_HP--;                    //감기
                break;
            case 3: // 많이아픔
                m_HP = m_HP - 3;
                break;
            default:
                Debug.Log("slime_ache_Bug");
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
        PlayerPrefs.SetInt("level", m_level);
        PlayerPrefs.Save();
    }

    public void testfood()
    {
        eat(1);
    }

    void eat(int myFood)
    {

        switch (myFood)
        {
            case 1:// 30프로 확률로 배탈 , 음식물 쓰레기
                if (player.basicFood > 0)
                {
                    Debug.Log(player.playerMoney);
                    Debug.Log(player.basicFood);
                    player.basicFood--;
                    m_HP = m_HP + 5;
                    m_stomach = m_stomach + 30;
                    if ((int)(Random.Range(0, 3) % 3) == 1)
                    {
                        m_health = 1;
                    }
                    foodNum++;
                }
                break;
            case 2://일반사료
                if (player.middleFood > 0)
                {
                    m_HP = m_HP + 5;
                    m_stomach = m_stomach + 20;
                    player.middleFood--;
                    foodNum++;
                }
                break;
            case 3: //고급사료
                if (player.higherFood > 0)
                {
                    player.higherFood--;
                    m_HP = m_HP + 10;
                    m_stomach = m_stomach + 30;
                    foodNum++;
                }
                break;
            case 4: // 포션
                if (player.veryFood > 0)
                {
                    m_HP = m_HP + 20;
                    player.veryFood--;
                    foodNum++;
                }
                break;
            default:
                break;
        }
        if (m_HP > 100) { m_HP = 100; }
        if (m_stomach > 100) { m_stomach = 100; }


    }

    void Poo()
    {
        if(foodNum == 4)
        {
            // SlimePooController 스크립트를 만들기. 
            // 
        }
    }

    public int getFoodnum()
    {
        return foodNum;
    }

    public void setFoodNum()
    {
        foodNum = 0;
    }
}
