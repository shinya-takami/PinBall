using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI関連クラスを使用できるようにする
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    // UIオブジェクト"Text Score"を格納する変数
    public GameObject textScore;
    // テキストコンポーネントを格納する変数
    private Text text;

    // ゲームの初期処理
    void Start()
    {
        // 変数"textScore"に格納されたUIオブジェクトの
        // "Text"コンポーネントを取得して変数"text"に格納
        text = textScore.GetComponent<Text>();
    }

    // ゲーム実行中の繰り返し処理
    void Update()
    {
        // "Text"コンポーネントの"text"フィールドにスコアの値を代入
        //（スクリプト"Manager"の変数"score"の値を文字列として参照）
        text.text = "SCORE: " + Manager.score.ToString();
    }
}