using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    public int startinghealth = 1;
    public int currentHealth;
    bool isDead = false;

	// Use this for initialization
	void Start () {
        currentHealth = startinghealth;
	}
	
	// Update is called once per frame
	void Update () {
	    if(isDead){
            Destroy(gameObject);
        }
	}

    public void TakeDamage()
    {
        if(isDead){
            return;
        }
        currentHealth--;
        if(currentHealth<=0){
            isDead = true;
        }
    }

   
}
