using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimePooController : MonoBehaviour {

    public GameObject slimePoo; 
    public Slime mySlime;
    public int nextIndex;
    // 다음에 쌀 똥의 Index
    GameObject[] slimePoos;
    Sweep sweepController;

    private void Awake()
    {
        slimePoos = new GameObject[10]; 
      
        for(int i = 0; i < 10; i++)
        {
            slimePoos[i] = Instantiate(slimePoo, new Vector2(100, 100), Quaternion.identity);
            Debug.Log("slime is instantiate");
            slimePoos[i].transform.position = new Vector2(100, 100);
            slimePoos[i].SetActive(false);
        }
        nextIndex = PlayerPrefs.GetInt("nextindex", 0);
    }

    void Start()
    {
        for (int i = 0; i < nextIndex; i++)
        {
            int randomX = Random.Range(-1, 0);
            int randomY = Random.Range(-3, -1);
            slimePoos[i].transform.position = new Vector2(randomX, randomY);
            slimePoos[i].SetActive(true);
        }
    }

    void slimePooInstance()
    {
        if (nextIndex < 10) // 10개 넘게싸면 생성 못함.
        {
            int randomX = Random.Range(-1, 0);
            int randomY = Random.Range(-3, -1);
            slimePoos[nextIndex].transform.position = new Vector2(randomX, randomY);
            slimePoos[nextIndex].SetActive(true);
            // 다음 똥을 켜줌

            nextIndex++;
            PlayerPrefs.SetInt("nextindex", nextIndex);
            PlayerPrefs.Save();
        }
        if(nextIndex == 10)
        {
            Debug.Log("10개 다 쌈");
        }
    }

    public void slimeIsPood() 
    {
        switch (mySlime.foodNum)
        {
            case 1:
               
                break;
            case 2:
                
                slimePoos[nextIndex].transform.localScale += new Vector3(1, 1);
                
                break;
            case 3:
                
                slimePoos[nextIndex].transform.localScale += new Vector3(2, 2);
               
                break;
            default:
                break;
         }
        if (nextIndex >= 0) // safety
        {
            slimePooInstance();
        }
        mySlime.FoodNumInitiate();
    }

	public void SweepPoo() // 똥 치우는 코드
    {
        if(sweepController.duringSweep == true)
        {
            slimePoos[nextIndex - 1].SetActive(false);
            nextIndex--;
            PlayerPrefs.SetInt("nextindex", nextIndex);
            PlayerPrefs.Save();
        }
    }

    public void OnMouseDown()
    {
        SweepPoo();
    }
}