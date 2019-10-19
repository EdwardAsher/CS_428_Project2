using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size_Button : MonoBehaviour
{
    public GameObject big;
    public GameObject small;
    public GameObject normal;
    public GameObject roof;
    public Transform trackedAlias;
    public GameObject camera;
    public GameObject leftControl;
    public GameObject rightControl;

    //AudioSource sound;
    //private bool setActive;
    // Start is called before the first frame update
    void Start()
    {
        /*big = GameObject.Find("Sizes/Big");
        small = GameObject.Find("Small");
        normal= GameObject.Find("Normal");
        roof = GameObject.Find("All Ceiling");
        trackedAlias = GameObject.Find("TrackedAlias").transform;*/
        //roof.SetActive(true);

        //lights.SetActive(true);
        //sound = GetComponent<AudioSource>();
        //setActive = true;
    }

    // Update is called once per frame
    void Update()
    {   
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Right Interactor" && normal.activeSelf == true && this.gameObject.name == "Grow Button")
        {
            //Vector3 test = trackedAlias.localPosition;
            normal.SetActive(false);
            big.SetActive(true);
            camera.transform.localPosition += new Vector3(0, 10, 0);
            //trackedAlias.localScale += new Vector3(test.x, 5,test.z);
            //trackedAlias.localPosition = new Vector3(3, test.y, 10);
            roof.SetActive(false);
        }
        else if (collision.gameObject.name == "Right Interactor" && normal.activeSelf == true && this.gameObject.name == "Shrink Button")
        {
            //Vector3 test = trackedAlias.localPosition;
            normal.SetActive(false);
            small.SetActive(true);
            camera.transform.localPosition -= new Vector3(0, 1.3f, 0);
            //trackedAlias.localScale -= new Vector3(0.8f, 0.8f, 0.8f);
            //trackedAlias.localPosition = new Vector3(2, test.y, -2);
        }
        else if (collision.gameObject.name == "Right Interactor" && big.activeSelf == true && this.gameObject.name == "Shrink Button")
        {
            //Vector3 test = trackedAlias.localPosition;
            big.SetActive(false);
            normal.SetActive(true);
            camera.transform.localPosition -= new Vector3(0, 10, 0);
            //trackedAlias.localScale -= new Vector3(test.x, 5, test.z);
            //trackedAlias.localPosition = new Vector3(0, test.y, 0);
            roof.SetActive(true);
        }
        else if (collision.gameObject.name == "Right Interactor" && small.activeSelf == true && this.gameObject.name == "Grow Button")
        {
            //Vector3 test = trackedAlias.localPosition;
            small.SetActive(false);
            normal.SetActive(true);
            camera.transform.localPosition += new Vector3(0, 1.3f, 0);
            //trackedAlias.localScale += new Vector3(0.8f, 0.8f, 0.8f);
            //trackedAlias.localPosition = new Vector3(0, test.y, 0);
        }
        Debug.Log(collision.gameObject.name);
        //if (collision.relativeVelocity.magnitude > 2)
        //    audioSource.Play();
    }
}
