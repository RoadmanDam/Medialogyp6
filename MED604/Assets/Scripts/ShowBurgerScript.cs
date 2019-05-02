using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBurgerScript : MonoBehaviour {

	public GameObject burger;

	// Use this for initialization
	public void ShowBurger() {
		burger.GetComponent<BurgerScript>().ShowBurger();
	}
}
