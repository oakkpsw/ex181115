using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {

	// Use this for initialization

	public int score;

	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void AddScore(int boost){
		
		score += boost;

		
	}
}
