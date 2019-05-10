using UnityEngine;

public class RefugeeSpawner : MonoBehaviour
{

    public GameObject[] refugee = new GameObject[2];
    public float spawnTime = 60f;
    public Transform[] spawnPoints;

    public Narration_o_matic narration_o_matic;

    public float lowerLimit = 5f;

    void Start ()
    {
       //Invoke("StartSpawn", spawnTime);
    }

    void Update(){

    }

    public void StartSpawn() {
        Spawn();
        spawnTime -= 10f;
        if (spawnTime < lowerLimit) {
            spawnTime = lowerLimit;
        }
        Invoke("StartSpawn", spawnTime);
    }


    void Spawn () {
         int spawnPointIndex = Random.Range(0, spawnPoints.Length);
         int refugeeIndex = Random.Range(0, refugee.Length);
         Instantiate(refugee[refugeeIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
