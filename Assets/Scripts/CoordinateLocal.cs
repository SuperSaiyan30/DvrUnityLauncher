using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 将物体坐标轴改变后绑定此脚本，可以发现物体沿局部坐标系移动
 */
public class CoordinateLocal: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward*Time.deltaTime);
	}
}
