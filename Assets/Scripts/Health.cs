using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Health : MonoBehaviour {

	// Use this for initialization
	int health = 0;
	public Text txt;
	public GameObject player;
	
	void Start () {
		health = 0;
		player = GameObject.FindWithTag("Player");
		txt = gameObject.GetComponent<Text>(); 
		txt.text = "Health :  " + health;
	}
	
	// Update is called once per frame
	void Update () {
		health = player.GetComponent<PlayerHealth> ().health;
		txt.text = "Health:  " + health;
		
	}

}