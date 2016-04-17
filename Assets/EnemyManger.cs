using UnityEngine;
using System.Collections;

public class EnemyManger : MonoBehaviour {

	// Use this for initialization
    public Health playerHealth;
    public GameObject enemy;       
    public float spawnTime = 5f;        
    public Transform[] spawnPoints;
    GameObject player;
	void Start () {
        player = GameObject.Find("Player");
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        playerHealth = player.GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Spawn () {
        if(playerHealth.currentHealth>0){
            int spawnPointIndex = Random.Range(0,spawnPoints.Length);
            Instantiate(enemy,spawnPoints[spawnPointIndex].position,spawnPoints[spawnPointIndex].rotation);
        }
	}
}
