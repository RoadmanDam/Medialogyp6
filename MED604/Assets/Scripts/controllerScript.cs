using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerScript : MonoBehaviour {

    bool naturebool = true;
    bool natureOnebool = false;

    public GameObject[] natureAmount = new GameObject[2];


	void Start () {

    }

    void Update()
    {
        //foreach (GameObject currNature in natureAmount)
        for (int i = 0; i < natureAmount.Length; i++)
        {
            if (natureOnebool == false){
                natureAmount[1].SetActive(false);
            } else {
                natureAmount[1].SetActive(true);
            }

            if (naturebool == false)
            {
                natureAmount[0].SetActive(false);
            }
            else
            {
                natureAmount[0].SetActive(true);
            }

            if (Input.GetKeyDown("space")){
                natureOnebool = true;
                naturebool = false;
            }

            if (Input.GetKeyDown("e"))
            {
                natureOnebool = false;
                naturebool = true;
            }
        }
    }
}