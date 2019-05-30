using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //変数宣言
    public static bool goal; //goal変数がtrueの時にゴールしたとする

    //初期化
    void Start()
    {
        goal = false;
    }

    //もし誰かが(GoalPoint)にぶつかったとき
    private void OnTriggerEnter(Collider cal)
    {
        //Playerタグを持ってるオブジェクトと接触したとき
        if(cal.gameObject.tag == "Player")
        {
            goal = true;
        }
    }
}
