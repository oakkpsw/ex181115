using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {

	int score = 0;
	public Text txt;
	public GameObject player;
	
	void Start () {
		player = GameObject.FindWithTag("Player");
		txt = gameObject.GetComponent<Text>(); 
		txt.text = "Score :  " + score;
	}
	
	// Update is called once per frame
	void Update () {
		score = player.GetComponent<PlayerScore>().score;
		txt.text = "Score :  " + score;

		}


}