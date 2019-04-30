using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurbineScript : MonoBehaviour {

	Animator TurbineAnimator;

	// Use this for initialization
	void Start () {
		TurbineAnimator = GetComponentInChildren<Animator>();
		TurbineAnimator.speed = Random.Range(1.0f, 2.0f);
	}	
	
}
