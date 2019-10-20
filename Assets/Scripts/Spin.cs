using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    private bool on;
    public AudioSource drill;
    void Start()
    {
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (on == true)
        {
            transform.Rotate(0, 70 * Time.deltaTime, 0); //rotates 50 degrees per second around z axis
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Right Interactor" && on == false)
        {
            drill.Play();
            on = true;
        }
        else if (collision.gameObject.name == "Right Interactor" && on == true)
        {
            on = false;
        }
        Debug.Log(collision.gameObject.name);
        //if (collision.relativeVelocity.magnitude > 2)
        //    audioSource.Play();
    }
}
