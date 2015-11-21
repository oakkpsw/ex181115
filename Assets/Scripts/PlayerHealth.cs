using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int health;
	int maxHealth;

	bool isDead;
	public GameObject Life1;
	public GameObject Life2;
	public GameObject Life3;

	void Start () {
		maxHealth = 10;
		//health = maxHealth;
		health = 10;
		isDead = false;
	}
	
	void Update () {

	//	Debug.Log("Health: " + health); 
	}

	public void GetDamage(int damage){
		Debug.Log("dam"); 
		health -= damage; // HP--;
	

		if(health <= 0 && !isDead){
			Die();
			Application.LoadLevel("Title"); 

		}

	}

	public void AddHealth(int boost){

		health += boost;

		if(health >= maxHealth){
			health = maxHealth;
		}

		
	}



	void Die(){
			
			
		
		Destroy(gameObject);

	}
}
