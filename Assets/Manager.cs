using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // スコア管理用の変数
    public static int score;

    // スコアの初期値を設定する変数
    public int initialScore;

    // ゲームの初期化
    void Start()
    {
        // [Inspector]ウィンドウのコンポーネントパネルで設定した
        //初期値"initialScore"の値を受け渡し用変数（static）に代入
        score = initialScore;
        // 変数の初期値入力

    }
}