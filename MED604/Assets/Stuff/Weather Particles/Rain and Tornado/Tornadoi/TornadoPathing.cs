using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoPathing : MonoBehaviour {

    public Transform point;
    public float speed = 0.1f;


    void Start()
    {
        Vector3 globalPos = point.transform.position;
        point.transform.parent = null;
        point.transform.position = globalPos;
    }

    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, point.position, speed * Time.deltaTime);
    }

}