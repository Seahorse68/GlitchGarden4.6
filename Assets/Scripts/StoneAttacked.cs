﻿using UnityEngine;
using System.Collections;

public class StoneAttacked : MonoBehaviour {
	private Animator animator;
	private Spawner myLaneSpawner;
	
	void Start() {
	
		animator = GameObject.FindObjectOfType<Animator>();
		
		SetMyLaneSpawner();
	}
	
	// look through all spawners and set myLanespawner if found
	void SetMyLaneSpawner () {
		Spawner[] spawnerArray = GameObject.FindObjectsOfType<Spawner>();
		
		foreach (Spawner spawner in spawnerArray) {
			if (spawner.transform.position.y == transform.position.y) {
				myLaneSpawner = spawner;
				return;
				
			}
		}
		
		Debug.LogError (name + " can't find spawner in lane");
	}
	
	void Update () {
		if (IsAttackerAheadInLane()) {
			animator.SetBool("isAttacking", true);
		} else {
			animator.SetBool("isAttacking", false);
		}
	}
	
	bool IsAttackerAheadInLane () {
		// exit if no attackers in lane
		if (myLaneSpawner.transform.childCount <= 0) {
			return false;
		}
		
		// if there are attackers, are they ahead
		foreach (Transform attacker in myLaneSpawner.transform) {
			if (attacker.transform.position.x > transform.position.x) {
				return true;
			}
		}
		
		// attacker in lane, but behind us
		return false;
	}
}
