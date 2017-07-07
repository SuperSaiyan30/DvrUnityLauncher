using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour {

    public Transform objTransform;
	// Use this for initialization
	void Start () {
        objTransform = GameObject.Find("Cube").GetComponent<Transform>();
        if (objTransform)
        {
            var dist = Vector3.Distance(objTransform.position,transform.position);
            Debug.Log("Distance:"+dist);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
		//Transform myTransform = GetComponent<Transform> ();
	}
}
