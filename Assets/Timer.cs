using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Timer : MonoBehaviour
{
    //時間経過をしめす[time]変数
    public static float time;

    //初期化
    void Start()
    {
        //ゲーム開始時はtimeは0
        time = 0;
    }

    void Update()
    {
        if(Goal.goal == false)
        {
            //経過時間を追加
            time = time + Time.deltaTime;

            //小数点以下を切り捨てる
            int t = Mathf.FloorToInt(time);

            //Text」Componentを取得して、「uiText」に格納
            Text uiText = GetComponent<Text>();

            //テキストを編集
            uiText.text = "Time=" + t;
        }
    }

}
