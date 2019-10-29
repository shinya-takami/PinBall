using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {


	// 接触した時の処理
	void OnCollisionEnter (Collision collision) {

        //スコアを加算
        Debug.Log("Hit");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
