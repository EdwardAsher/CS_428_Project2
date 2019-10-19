using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Collision_Sound : MonoBehaviour
{
    public AudioSource sound;
    bool setActive;
    // Start is called before the first frame update
    void Start()
    {
        //music = GetComponent<AudioSource>();
        sound.Stop();
        setActive = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        if (collision.gameObject.name == "Right Interactor" && setActive == false)
        {
            sound.Play();
            

            setActive = true;
        }
        else if (collision.gameObject.name == "Right Interactor" && setActive == true)
        {
            sound.Stop();
            setActive = false;
        }
        Debug.Log(collision.gameObject.name);
        //if (collision.relativeVelocity.magnitude > 2)
        //    audioSource.Play();
    }
}
