using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	// Use this for initialization

	Rigidbody playerRigidbody;
	public GameObject player;
	float attack; 
	int playerHealth;

	void Start () {
		attack = 100.0f;
		player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

	}
	 void OnCollisionEnter(Collision obj){
		
		if(obj.gameObject.CompareTag("Player")){

			Debug.Log("aaa");
			player.GetComponent<PlayerHealth>().GetDamage(1);
			//playerRigidbody.AddForce(-transform.forward*1000,ForceMode.Acceleration);
			//playerRigidbody.useGravity = true;

			//Destroy(gameObject);
		}
		
	}
}
