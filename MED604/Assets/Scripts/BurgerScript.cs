using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerScript : MonoBehaviour {

	public BurgerButtonScript burgerButtonScript;
	public GameObject particles;

	bool firstGrab = true;
	bool grapped = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Grabbed() {
		grapped = true;
		this.gameObject.name = "GRABBED BURGER";
		burgerButtonScript.CreateNewBurger();
	}
	public void ShowBurger() {
		this.gameObject.SetActive(true);
		particles.transform.parent = this.transform;
	}

	public void EatBurger() {
		particles.SetActive(true);
		particles.transform.parent = burgerButtonScript.buttonRoot.transform;
		particles.transform.position = this.transform.position;
		this.gameObject.GetComponent<OVRGrabbable>().GrabEnd(Vector3.zero, Vector3.zero);
	}
}
