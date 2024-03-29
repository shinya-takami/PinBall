﻿using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {

    //最小サイズ
    private float minimum = 0.8f;
    //拡大縮小スピード
    private float magSpeed = 9.0f;
    //拡大率
    private float magnification = 0.10f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //雲を拡大縮小
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
    }
}
