using UnityEngine;
using System.Collections;

public class ScoreCoin : MonoBehaviour {

	public float speed;




	void Start () {
		speed = 360.0f;
	}

	void Update () {
		transform.Rotate (0.0f, speed * Time.deltaTime, 0.0f);
	
	}
	void OnTriggerEnter(Collider obj){

		if(obj.gameObject.CompareTag("Player")){

				obj.GetComponent<PlayerScore>().AddScore(1);

			Destroy(gameObject);
		}

	}

}
