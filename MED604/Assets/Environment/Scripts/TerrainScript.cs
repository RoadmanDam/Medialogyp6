using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour
{
    public GameObject[] stuffToMove = new GameObject[2];
    public float MoveSpeed = .5f; //speed to scroll roads at

    void Start()
    {
      
    }
    void Update()
    {
      foreach(GameObject obj in stuffToMove){
        Vector3 newTerrainPos = obj.transform.localPosition;
        newTerrainPos.z -= MoveSpeed * Time.deltaTime;
        obj.transform.localPosition = newTerrainPos;
      }

    }
}
