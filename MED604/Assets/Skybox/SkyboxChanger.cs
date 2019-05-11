using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChanger : MonoBehaviour {

	public Material skybox1, skybox2;

	Material skybox1Temp, skybox2Temp;

	public float timeToChange = 1;

	[HideInInspector]
	public int skyboxWant = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		skybox1Temp = new Material(skybox1);
		skybox2Temp = new Material(skybox2);
		ChangeSkybox(skyboxWant);
	}

	void ChangeSkybox(int skyboxWant) {
		if (skyboxWant == 1)
			RenderSettings.skybox.Lerp(RenderSettings.skybox, skybox1Temp, timeToChange * Time.deltaTime);
		else if(skyboxWant == 2)
			RenderSettings.skybox.Lerp(RenderSettings.skybox, skybox2Temp, timeToChange * Time.deltaTime);
	}


}
