using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Paper : MonoBehaviour
{

    public GameObject promptObject;

    // Start is called before the first frame update
    void Start()
    {
        promptObject = GameObject.Find("Prompt Text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {

            promptObject.GetComponent<TextMeshPro>().text = "Press E to collect";

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Paper collected");
                Destroy(this.gameObject);

                promptObject.GetComponent<TextMeshPro>().text = "Paper collected";
            }
        }
    }
}
