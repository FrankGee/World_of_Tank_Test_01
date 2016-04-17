using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
    /**
    public float speed = 0.5f;
    Vector3 movement;
    Rigidbody playerRigidbody;

	void Start () {
	    playerRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //float trans = Input.GetAxis("Vertical")*speed;
       // trans *= Time.deltaTime;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
       // transform.Translate(0,0,trans);
        Move(v,h);
       
	}

    void Move(float h, float v)
    {
        movement.Set(-h,0f,v);
        movement = movement.normalized * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movement);
    }

  **/
     
    
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0,Space.Self);
    }
     
}
