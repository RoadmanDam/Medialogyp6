using UnityEngine;

public class RefugeeSpawner : MonoBehaviour
{

    public GameObject[] refugee = new GameObject[2];
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    void Start ()
    {
       InvokeRepeating("Spawn", spawnTime, spawnTime);

    }

    void Update(){

    }


     void Spawn ()
    {
         int spawnPointIndex = Random.Range(0, spawnPoints.Length);
         int refugeeIndex = Random.Range(0, refugee.Length);
         Instantiate(refugee[refugeeIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);


    }
}
