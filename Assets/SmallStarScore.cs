using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallStarScore : MonoBehaviour
{
    // 加算するスコアの値を格納する変数
    public int scorePoint;

    // 接触した時の処理
    void OnCollisionEnter(Collision collision)
    {
        // スコアを加算
        //（スクリプト"Manager"の変数"score"を変更）
        Manager.score += scorePoint;
    }
}