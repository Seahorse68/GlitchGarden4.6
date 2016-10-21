using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	[Tooltip ("Average number of seconds betwen appearances")]
	public float seenEverySeconds;
	public float currentSpeed;
	private GameObject currentTarget;
	private Animator animator;

	// Use this for initialization
	void Start () {
		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
		myRigidBody.isKinematic = true;
		//animator = GetComponent<Animator>();
		animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
		//print (currentSpeed);
		if (!currentTarget) {
			animator.SetBool ("isAttacking", false);
		}
		
	}
	
	void OnTriggerEnter2D () {
		//Debug.Log (name + " trigger enter");
	}
	
	public void SetSpeed(float speed) {
		currentSpeed = speed;
	}
	
	// called from the animator at time of actual blow
	public void StrikeCurrentTarget(float damage) {
		if (currentTarget) {
			Health health = currentTarget.GetComponent<Health>();
			if (health) {
				health.DealDamage(damage);
			}
		}
	}
	
	public void Attack (GameObject obj) {
		currentTarget = obj;
		
	}
	
	
}
