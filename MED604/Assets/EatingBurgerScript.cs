using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingBurgerScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		print(other.name);
		if (other.tag == "Burger" && other.gameObject.name == "GRABBED BURGER") {
			EatBurger(other.gameObject);
		}
	}

	public void EatBurger(GameObject obj) {
		obj.GetComponent<BurgerScript>().EatBurger();
	}
}
