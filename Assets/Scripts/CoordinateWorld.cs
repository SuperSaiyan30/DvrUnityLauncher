using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 测试InverseTransformDirection，将向量从局部坐标系转到全局坐标系
 */
public class CoordinateWorld : MonoBehaviour {
    private Vector3 objVector3;
    // Use this for initialization

    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        // Example: get controller's current orientation:
        Quaternion ori = GvrController.Orientation;

        // If you want a vector that points in the direction of the controller
        // you can just multiply this quat by Vector3.forward:
        Vector3 vector = ori * Vector3.forward;

        // ...or you can just change the rotation of some entity on your scene
        // (e.g. the player's arm) to match the controller's orientation
        transform.localRotation = ori;
        //objVector3 = transform.InverseTransformDirection(Vector3.forward);
        //transform.Translate(objVector3*Time.deltaTime);

        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Vector3 controllerStartPos;
        controllerStartPos.x = 137.1F;
        controllerStartPos.y = 12.5F;
        controllerStartPos.z = -9.4F;
        Ray ray1 = new Ray(controllerStartPos, vector);
        Debug.DrawLine(controllerStartPos,transform.position, Color.red);
        /*
        if (Physics.Raycast(controllerStartPos, vector, out hit, 1000))
        {
            Debug.DrawLine(controllerStartPos, hit.point, Color.red);
        }
        */
       
    }
}
