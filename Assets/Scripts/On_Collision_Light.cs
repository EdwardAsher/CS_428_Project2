using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Collision_Light : MonoBehaviour
{
    public GameObject lights;
    AudioSource sound;
    private bool setActive;
    // Start is called before the first frame update
    void Start()
    {
        lights.SetActive(true);
        sound = GetComponent<AudioSource>();
        setActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Right Interactor" && setActive == false)
        {
            lights.SetActive(true);
            sound.Play();
            setActive = true;
        }
        else if (collision.gameObject.name == "Right Interactor" && setActive == true)
        {
            lights.SetActive(false);
            sound.Play();
            setActive = false;
        }
        Debug.Log(collision.gameObject.name);
        //if (collision.relativeVelocity.magnitude > 2)
        //    audioSource.Play();
    }
}
