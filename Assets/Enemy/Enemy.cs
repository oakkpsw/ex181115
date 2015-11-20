using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	NavMeshAgent enemyAgent;
	
	Transform player;
	
	Animator animator;

	BoxCollider boxcheck;

	bool isStopped;
	int acta = 0;
	void Start () {
		animator = GetComponent<Animator>();
		enemyAgent = GetComponent<NavMeshAgent>();
		enemyAgent.speed = 0.0f;
		boxcheck = GetComponent<BoxCollider> ();
		player = GameObject.FindGameObjectWithTag("Player").transform;
		
		isStopped = false;
	}
	public void gooo(){
		acta = 1;
	}
	
	void Update () {
		if(acta == 1){
			animator.SetBool("walkE",false);
			animator.SetBool("runE",false);
			animator.SetBool("die",true);
		}
		if(player != null){
			//enemyAgent.transform.LookAt(player.position);
			
			Vector3 location = transform.position-player.position;





			//Debug.LogError("distance: " + location.magnitude);
			
			/*
			if(location.magnitude <= 2.0){
				animator.SetBool("walkE",false);
				enemyAgent.Stop();
				isStopped = true;
			}else if(location.magnitude <= 5.0){
				
				if(isStopped){
					animator.SetBool("walkE",true);
					enemyAgent.Resume();
					isStopped = false;
				}
				animator.SetBool("runE",false);
				animator.speed = 1.5f;
				enemyAgent.speed = 1.0f;
			}else if(location.magnitude <= 15.0){
				
				//animator.SetBool("walk",false);
				
				animator.SetBool("runE",true);
				animator.speed = 1.0f;
				enemyAgent.speed = 3.0f;
			}else{
				animator.SetBool("walkE",true);
				animator.speed = 1.5f;
				enemyAgent.speed = 1.0f;
			}*/
			animator.SetBool("walkE",true);
			//animator.SetBool("cron",true);
			animator.speed = 1.0f;
			enemyAgent.speed = 0.8f;
			enemyAgent.SetDestination(player.position);
			
		    //Debug.Log (animator.GetBool("walkE") +" ttt " + animator.GetBool("cron"));
			//Debug.Log();
		}
	}
	/*
	void OnCollisionEnter(Collision col) {

		if (col.gameObject.tag == "Tunnel") {
			//animator.SetBool ("cron", true);
			Debug.Log (col.gameObject.name +" 2222");
		} else if(col.gameObject.tag == "Player"){
			//animator.SetBool ("cron", false);
			Debug.Log (col.gameObject.name);
		}
		//animator.SetBool ("cron", true);

	}*/
	void OnTriggerEnter(Collider a) {
		if (a.tag == "Tunnel") {
			animator.SetBool ("cron", true);
			//Debug.Log (animator.GetBool ("cron"));
		} else {
			animator.SetBool ("cron", false);
		}
		Debug.Log (a.name);
	}
}
