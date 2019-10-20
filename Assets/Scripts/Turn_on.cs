using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_on : MonoBehaviour
{
    public GameObject blankScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (blankScreen.activeSelf == true)
        {
            if (collision.gameObject.name == "Right Interactor")
            {
                blankScreen.SetActive(false);
            }
        }
        
        Debug.Log(collision.gameObject.name);
        //if (collision.relativeVelocity.magnitude > 2)
        //    audioSource.Play();
    }
}
