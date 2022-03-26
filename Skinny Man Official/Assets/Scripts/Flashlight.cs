using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    public GameObject light;
    public AudioSource lightClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            light.SetActive(!isActive(light));
            lightClick.Play();
        }

    }

    public bool isActive(GameObject light)
    {
        if (light.active == true)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
