using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefMoover : MonoBehaviour {

    public float refSlideSpeed = 1.5f;
    const float refLength = 60;

    void Start () {
		
	}
	
	void Update () {
        Vector3 newPos = this.transform.position;
        newPos.z -= refSlideSpeed * Time.deltaTime;
        this.transform.position = newPos;

        if (newPos.z < -refLength){
            Destroy(gameObject);
        }
    }
}
