using UnityEngine;
using System.Collections;

public class aaaa : MonoBehaviour {

	private NavMeshAgent nav;
	private Animator animator;
	
	private CapsuleCollider collider;
	private float colliderHeight;
	private Vector3 colliderCenter;
	
	private bool isCrouching;
	
	private Transform target;
	
	private RaycastHit groundHit;
	private bool onGround;
	
	private float speed;
	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		nav = GetComponent<NavMeshAgent> ();
		collider = GetComponent<CapsuleCollider> ();
		
		colliderHeight = collider.height;
		colliderCenter = collider.center;
		
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		
		nav.SetDestination (target.position);
	}	
	
	// Update is called once per frame
	void Update () {
		
		CheckGround ();
		
		if(target != null)
			nav.SetDestination (target.position);
		
		speed = Vector2.SqrMagnitude (new Vector2(nav.velocity.x, nav.velocity.z));
		//Debug.Log (nav.remainingDistance);
		speed = Mathf.Clamp (speed, 0f, 1f);
		
		animator.SetFloat ("speed", speed);
		animator.SetBool ("onGround", onGround);
		animator.SetBool ("crouch", isCrouching);
	}
	
	void OnTriggerStay(Collider other){
		if (other.tag == "Tunnel") {
			Debug.Log ("Stay");
			isCrouching = true;
			collider.center = colliderCenter/1.4f;
			collider.height = colliderHeight/1.4f;
		}	
	}
	
	void OnTriggerExit(Collider other){
		isCrouching = false;
		
		collider.center = colliderCenter;
		collider.height = colliderHeight;
	}
	
	void CheckGround(){
		Ray ray = new Ray(transform.position + new Vector3(0, colliderHeight / 2, 0), Vector3.down);
		float groundDistance = Mathf.Infinity;
		
		if (Physics.Raycast(ray, out groundHit, Mathf.Infinity))
			groundDistance = transform.position.y - groundHit.point.y;
		
		if(Mathf.Abs (groundDistance) <= 0.2f)
			onGround = true;
		else
			onGround = false;
		
	}
}
