using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {
    public string shooter;
    public GameObject ExploPtcl;
    float speed = 200f;
    float range = 400f;
    float dist;
	// Use this for initialization
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        dist += Time.deltaTime * speed;
        if (dist >= range)
        {
            Instantiate(ExploPtcl, transform.position, transform.rotation);
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(ExploPtcl, transform.position, transform.rotation);
        if(collision.collider.tag != shooter){
         
            Health targetHealth = collision.collider.GetComponent<Health>();
            if (targetHealth!=null){
          
                targetHealth.TakeDamage();
            }
        }
        Destroy(gameObject);
       
        
    }
    
}
