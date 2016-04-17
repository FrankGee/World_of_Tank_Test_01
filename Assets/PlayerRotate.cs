using UnityEngine;
using System.Collections;

public class PlayerRotate : MonoBehaviour {
    float rayLength = 100f;
    int floorMask;
	// Use this for initialization
	void Start () {
        floorMask = LayerMask.GetMask("Plane");
	}
	
	// Update is called once per frame
	void Update () {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       /**
        RaycastHit floorHit;

        if(Physics.Raycast(camRay,out floorHit, rayLength, floorMask)){
            Vector3 turretToMouse = floorHit.point - transform.position;
            turretToMouse.y = 0f;
            Quaternion rotation = Quaternion.LookRotation(turretToMouse);
        }
        * **/
	}
}
