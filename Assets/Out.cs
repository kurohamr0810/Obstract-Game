using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UnityでScene関係操作を扱う時につかう
using UnityEngine.SceneManagement;

public class Out : MonoBehaviour
{
    //誰かが自分に接触した場合
    private void OnTriggerEnter(Collider col)
    {
        //Playerという名前のタグと接触した場合
        if(col.gameObject.tag == "Player")
        {
            //今のSceneをもう一度読み込む
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
