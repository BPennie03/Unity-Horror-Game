using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperManager: MonoBehaviour
{

    public GameObject paperManager;

    int papersCollected;



    // Start is called before the first frame update
    void Start()
    {

        GameObject[] paperArray = GameObject.FindGameObjectsWithTag("Paper");

        List<GameObject> paperList = new List<GameObject>();

        for (int i = 0; i < paperArray.Length; i++)
        {
            paperList.Add(paperArray[i]);
            Debug.Log("paper added: " + paperArray[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}
