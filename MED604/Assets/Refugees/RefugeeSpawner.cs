using UnityEngine;

public class RefugeeSpawner : MonoBehaviour
{

    public GameObject[] refugee = new GameObject[2];
    public float spawnTime = .1f;
    public Transform[] spawnPoints;

    public Narration_o_matic narration_o_matic;

    public float lowerLimit = .1f;

    public bool shouldSpawn = true;

    void Start ()
    {
       //Invoke("StartSpawn", spawnTime);
    }

    void Update(){

    }

    public void StartSpawn() {
        if (shouldSpawn) {
            Spawn();
            spawnTime -= 1f;
            if (spawnTime < lowerLimit) {
                spawnTime = lowerLimit;
            }
        }
        Invoke("StartSpawn", spawnTime);
    }

    public void StopSpawn() {
        shouldSpawn = false;
    }


    void Spawn () {
         int spawnPointIndex = Random.Range(0, spawnPoints.Length);
         int refugeeIndex = Random.Range(0, refugee.Length);
         Instantiate(refugee[refugeeIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
