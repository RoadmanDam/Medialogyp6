using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class BurgerButtonScript : MonoBehaviour {
	
	public NVRButton Button;

	public GameObject buttonRoot;

	public GameObject burgerFab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void OnTriggerEnter(Collider other) {
		if ((other.name == "RightHandAnchor" || other.name == "LeftHandAnchor")) {
			OpenBurgerDoor();
		}
	}

	public void OpenBurgerDoor() {
		if (buttonRoot.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Burger Closed"))
			buttonRoot.GetComponent<Animator>().Play("Burger Open");
	}

	public void CloseBurgerDoor() {
		if (!buttonRoot.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Burger Close"))
			buttonRoot.GetComponent<Animator>().Play("Burger Close");
	}

	public void CreateNewBurger() {
		//GameObject newBurger = Instantiate(burgerFab, burgerFab.transform.position, Quaternion.identity, buttonRoot.transform);
		Invoke("CloseBurgerDoor", 1.5f);
	}
}
