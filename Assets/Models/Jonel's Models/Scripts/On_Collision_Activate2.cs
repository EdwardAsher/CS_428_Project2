using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Collision_Activate2 : MonoBehaviour
{
    public GameObject item;

    bool setActive;
    // Start is called before the first frame update
    void Start()
    {
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
            item.SetActive(true);
            setActive = true;
        }
        else if (collision.gameObject.name == "Right Interactor" && setActive == true)
        {
            item.SetActive(false);
            setActive = false;
        }
        Debug.Log(collision.gameObject.name);
        //if (collision.relativeVelocity.magnitude > 2)
        //    audioSource.Play();
    }
}
