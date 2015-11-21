using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	int health;
	int maxHealth;

	bool isDead;
	public GameObject Life1;
	public GameObject Life2;
	public GameObject Life3;

	void Start () {
		maxHealth = 3;
		//health = maxHealth;
		health = 3;
		isDead = false;
	}
	
	void Update () {

	//	Debug.Log("Health: " + health); 
	}

	public void GetDamage(int damage){
		Debug.Log("dam"); 
		health -= damage; // HP--;
		setHPbar();

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
		setHPbar();
		
	}

	public void setHPbar(){
		if (health == 3) {
			Life1.SetActive (true);
			Life2.SetActive (true);
			Life3.SetActive (true);
		} else if (health == 2) {
			Life1.SetActive (true);
			Life2.SetActive (true);
			Life3.SetActive (false);
		} else if (health == 1) {
			Life1.SetActive (true);
			Life2.SetActive (false);
			Life3.SetActive (false);
		}
	}

	void Die(){
			Life1.SetActive (false);
			Life2.SetActive (false);
			Life3.SetActive (false);
			
		
		Destroy(gameObject);

	}
}
