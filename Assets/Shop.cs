using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Player player;
    
  private void Start()
    {

    }

    private void Update()
    {

    }

    public void purchase1()
    {
        if (player.playerMoney >= 100)// 스태틱은 안쓰는게좋음
        {
            player.SetMoney(player.playerMoney - 100);
            player.SetFood(Player.Food.BASIC, player.Foods[(int)Player.Food.BASIC] + 1);
            Debug.Log("playermoney is" + player.playerMoney);
            Debug.Log("basicFood are" + player.Foods[(int)Player.Food.BASIC]);
        }
        else {
            Debug.Log("돈이 부족합니다.");
        }
    }

    public void purchase2()
    {
        if (player.playerMoney >= 200)// 스태틱은 안쓰는게좋음
        {
            player.SetMoney(player.playerMoney - 200);
            player.SetFood(Player.Food.MIDDLE, player.Foods[(int)Player.Food.MIDDLE] + 1);
            Debug.Log("playermoney is" + player.playerMoney);
            Debug.Log("middleFood are" + player.Foods[(int)Player.Food.MIDDLE]);
        }
    }
    public void purchase3()
    {
        if(player.playerMoney >= 300)// 스태틱은 안쓰는게좋음
        {
            player.SetMoney(player.playerMoney - 300);
            player.SetFood(Player.Food.HIGHER, player.Foods[(int)Player.Food.HIGHER] + 1);
            Debug.Log("playermoney is" + player.playerMoney);
            Debug.Log("higherFood are" + player.Foods[(int)Player.Food.HIGHER]);
        }
    }
 
    /*
    public void purchase4()
    {
        if (player.playerMoney >= 200)// 스태틱은 안쓰는게좋음
        {
             Player.m_money = Player.m_money - 200;
             playerScript.food3++;

            Debug.Log(Player.m_money);
            Debug.Log(playerScript.food3);
        }
    }
    */

    // 이것도 추후 switch 문으로 바꿀거임
/*

    public void InShop()
    {
        Application.LoadLevel("shop")
    }

    public void OutShop()
    {
        Application.LoadLevel("menu1");
    }

    SceneManagement 쓰는 방법도 생각해 보는게 좋을 것 같아서 일단 보류.
*/
}
