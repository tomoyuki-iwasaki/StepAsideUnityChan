using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_destroy : MonoBehaviour
{

    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //UnityちゃんとItemの距離
    private float Idifference;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //UnityちゃんとItemの位置（z座標）の差を求める
        this.Idifference = unitychan.transform.position.z - this.transform.position.z;

        if (this.Idifference >= 5)
        {
//            Debug.Log(this.Idifference);
            //オブジェクトを消す
            Destroy(this.gameObject);
        }
        else
        {
//            Debug.Log(this.Idifference);
        }







    }
}
