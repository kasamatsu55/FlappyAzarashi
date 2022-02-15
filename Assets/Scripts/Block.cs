using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float minHeight;
    public float maxHeight;
    public GameObject root;
    //隙間もランダムに生成してゲームの難易度を上げる
    public Transform bottomblock;

    // Start is called before the first frame update
    void Start()
    {
        //開始時に隙間の高さを変更
        ChangeHeight();
    }

    void ChangeHeight()
    {
        //ランダムな高さを生成して設定
        float height = Random.Range(minHeight, maxHeight);
        root.transform.localPosition = new Vector3(0.0f, height, 0.0f);
        //隙間
        float offset = Random.Range(-2f,2f);
        bottomblock.localPosition = new Vector3(0.0f,offset,0.0f);

    }

    //ScrollObjectスクリプトからのメッセージを受け取って高さを変更
    void OnScrollEnd()
    {
        ChangeHeight();
    }
}
