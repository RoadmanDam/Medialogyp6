using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoPathing : MonoBehaviour {

    public Transform p1, p2;
    float speed;
    bool onFirstPoint;
    bool onSecondPoint;


    void Start()
    {
        onFirstPoint = true;
        onSecondPoint = false;
    }

    void Update()
    {
        Patrol();
    }

    void Patrol(){
        speed = 0.1f * Time.deltaTime;

        if (onSecondPoint == false)
        {
            transform.position = Vector3.Lerp(transform.position, p2.position, speed);
        }

        if (Vector3.Distance(transform.position, p2.position) < 1f)
        {
            onSecondPoint = true;
            onFirstPoint = false;
        }

        if (Vector3.Distance(transform.position, p1.position) < 1f)
        {
            onFirstPoint = true;
            onSecondPoint = false;
        }

        if (onFirstPoint == false)
        {
            transform.position = Vector3.Lerp(transform.position, p1.position, speed);
        }
    }

}