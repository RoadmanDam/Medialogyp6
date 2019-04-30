using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadTest : MonoBehaviour
{

    int pieceIterator = -1;

    public List<string> wantedRoads = new List<string>();
    public List<Road> roadPieces = new List<Road>();

    List<GameObject> createdRoads = new List<GameObject>();

    [Range(0, 500)]
    public float roadPieceSize;
    public int roadLength = 7; //length of roads

    public float roadSpeed = 5f; //speed to scroll roads at

    void Start()
    {
        NextPiece();
    }

    void NextPiece() {
        pieceIterator++;
        for (int i = 0; i < roadLength; i++) {
            GameObject newRoad = Instantiate(roadPieces[pieceIterator].prefab, new Vector3(-94.67f, -1.45f, 48.05f*i), Quaternion.identity, this.transform);

            createdRoads.Add(newRoad);
        }
    }

    void MoveRoad() {

    }

    void CreateRoad() {

    }

    void DeleteRoad(int i) {

    }

    void UpdateRoads(int i) {
        for (int j = 0; j < roadLength; j++)
        {
            Vector3 newRoadPos = createdRoads[j].transform.position;
            newRoadPos.z -= roadSpeed * Time.deltaTime;
            if (newRoadPos.z < (-roadLength*48.05f) / createdRoads.Count)
            {
                newRoadPos.z += roadLength*48.05f;
            }
            createdRoads[j].transform.position = newRoadPos;
        }
    }


    void Update()
    {
        UpdateRoads(pieceIterator);
        
        /*
        foreach (GameObject road in RoadPieces)
        {
            Vector3 newRoadPos = road.transform.position;
            newRoadPos.z -= RoadSpeed * Time.deltaTime;
            if (newRoadPos.z < -RoadLength / RoadPieces.Length)
            {
                newRoadPos.z += RoadLength;
            }
            road.transform.position = newRoadPos;
        }*/
    }
}
