using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
    public int damage = 1;
    public float range = 100f;
    public GameObject fireEffect;
    public Rigidbody bullet;
    public Transform spawn;
    public float loading = 1f;
    float speed = 20;
    float timer = 1f;
    
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   if(Input.GetButton("Fire1")&&timer>loading){
           Shoot();
       }
       timer += Time.deltaTime;  
        
	}

    void Shoot()
    {
        timer = 0f;
        Rigidbody fire = Instantiate(bullet, spawn.position, spawn.rotation) as Rigidbody;
        Instantiate(fireEffect, spawn.position, spawn.rotation);
        fire.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        fire.GetComponent<Explode>().shooter = "Player";
    }
  
  
}
