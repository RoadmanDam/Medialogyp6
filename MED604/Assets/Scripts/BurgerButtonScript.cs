using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class BurgerButtonScript : MonoBehaviour {
	
	public NVRButton Button;

	public GameObject buttonRoot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 if (Button.ButtonDown)
            {
                buttonRoot.GetComponent<Animator>().Play("Burger Open");
            }
	}
}
