using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerScript : MonoBehaviour {

	public BurgerButtonScript burgerButtonScript;
	public GameObject particles;

	public Narration_o_matic narration_o_matic;

	public AudioClip bite, ding;

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
		this.transform.rotation = Quaternion.Euler(-90, 0, 90);
		this.gameObject.SetActive(true);
		this.gameObject.GetComponent<AudioSource>().PlayOneShot(ding);
		particles.transform.parent = this.transform;
		narration_o_matic.UpdateBurgerAmount();
	}

	public void EatBurger() {
		particles.SetActive(true);
		particles.GetComponent<AudioSource>().PlayOneShot(bite);
		particles.transform.parent = burgerButtonScript.buttonRoot.transform;
		particles.transform.position = this.transform.position;
		this.gameObject.GetComponent<OVRGrabbable>().GrabEnd(Vector3.zero, Vector3.zero);
		narration_o_matic.Activate_clip();
	}
}
