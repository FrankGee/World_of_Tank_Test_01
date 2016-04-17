using UnityEngine;
using System.Collections;

public class EnemyFire : MonoBehaviour {
    public GameObject bullet;
    public GameObject fireEffect;
    public GameObject player;
    public Transform spawn;
    public float loading = 10f;
    public float damage = 1f;
    Transform spawnPoint;
    float speed = 20;
    public float timer;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
    
       
	}
	
	// Update is called once per frame
	void Update () {
        float dis = Vector3.Distance(transform.position, player.transform.position);

        if(dis<100f ){
            float step = 5f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
        
        }
        if(timer>loading){
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
        fire.GetComponent<Explode>().shooter = "Enemy";
    }
}
