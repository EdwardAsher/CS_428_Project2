using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size2 : MonoBehaviour
{
    //public GameObject lights;
    private bool large;
    private bool small;
    private bool normal;
    public GameObject bigButton;
    public GameObject smallButton;
    public GameObject normalButton;
    public GameObject roof;
    public Transform trackedAlias;
    public GameObject camara;
    public GameObject leftControl;
    public GameObject rightControl;

    //AudioSource sound;
    //private bool setActive;
    // Start is called before the first frame update
    void Start()
    {
        large = false;
        small = false;
        normal = true;
        roof.SetActive(true);

        //lights.SetActive(true);
        //sound = GetComponent<AudioSource>();
        //setActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (normal == true && Input.GetKeyDown("b"))
        {
            //Vector3 test = trackedAlias.localPosition;

            normal = false;
            large = true;
            //trackedAlias.localScale += new Vector3(5, 5, 5);
            //trackedAlias.localScale += new Vector3(5, 5, 5);
            //trackedAlias.localPosition = new Vector3(-7, test.y, 20);
            camara.transform.localPosition += new Vector3(0, 10, 0);
            //rightControl.transform.localPosition += new Vector3(0, 8, 0);
            //leftControl.transform.localPosition += new Vector3(0, 8, 0);
            roof.SetActive(false);
            //bigButton.SetActive(true);
            //normalButton.SetActive(false);
        }
        else if (large == true && Input.GetKeyDown("l"))
        {
            //Vector3 test = trackedAlias.localPosition;

            normal = true;
            large = false;
            //trackedAlias.localScale -= new Vector3(5, 5, 5);
            //trackedAlias.localScale -= new Vector3(5, 5, 5);
            //trackedAlias.localPosition = new Vector3(0, test.y, 0);
            camara.transform.localPosition -= new Vector3(0, 10, 0);
            //rightControl.transform.localPosition -= new Vector3(0, 10, 0);
            //leftControl.transform.localPosition -= new Vector3(0, 10, 0);

            roof.SetActive(true);
            //normalButton.SetActive(true);
            //bigButton.SetActive(false);

            //trackedAlias.localPosition = new Vector3(-7, 0, 20);
        }
        else if (normal == true && Input.GetKeyDown("l"))
        {
            normal = false;
            small = true;
            //trackedAlias.localScale -= new Vector3(0.8f, 0.8f, 0.8f);
            camara.transform.localPosition -= new Vector3(0, 1.3f, 0);
            //rightControl.transform.localPosition -= new Vector3(0, 1f, 0);
            //leftControl.transform.localPosition -= new Vector3(0, 1f, 0);
            //smallButton.SetActive(true);
            //normalButton.SetActive(false);
        }
        else if (small == true && Input.GetKeyDown("b"))
        {
            normal = true;
            small = false;
            //trackedAlias.localScale += new Vector3(0.8f, 0.8f, 0.8f);
            camara.transform.localPosition += new Vector3(0, 1.3f, 0);
            //rightControl.transform.localPosition += new Vector3(0, 1f, 0);
            //leftControl.transform.localPosition += new Vector3(0, 1f, 0);
            //normalButton.SetActive(true);
            //smallButton.SetActive(false);
        }
        /*if (bigButton.activeSelf == true)
        {
            large = true;
            small = false;
            normal = false;
        }
        else if (smallButton.activeSelf == true)
        {
            large = false;
            small = true;
            normal = false;
        }
        else if (normalButton.activeSelf == true)
        {
            large = false;
            small = false;
            normal = true;
        }
        if (normal == true && Input.GetKeyDown("b"))
        {
            Vector3 test = trackedAlias.localPosition;
            
            normal = false;
            large = true;
            //trackedAlias.localScale += new Vector3(5, 5, 5);
            trackedAlias.localScale += new Vector3(5, 5, 5);
            //trackedAlias.localPosition = new Vector3(-7, test.y, 20);
            roof.SetActive(false);
            bigButton.SetActive(true);
            normalButton.SetActive(false);
        }
        else if (large == true && Input.GetKeyDown("l"))
        {
            Vector3 test = trackedAlias.localPosition;

            normal = true;
            large = false;
            //trackedAlias.localScale -= new Vector3(5, 5, 5);
            trackedAlias.localScale -= new Vector3(5, 5, 5);
            //trackedAlias.localPosition = new Vector3(0, test.y, 0);
            roof.SetActive(true);
            normalButton.SetActive(true);
            bigButton.SetActive(false);

            //trackedAlias.localPosition = new Vector3(-7, 0, 20);
        }
        else if (normal == true && Input.GetKeyDown("l"))
        {
            normal = false;
            small = true;
            trackedAlias.localScale -= new Vector3(0.8f, 0.8f, 0.8f);
            smallButton.SetActive(true);
            normalButton.SetActive(false);
        }
        else if (small == true && Input.GetKeyDown("b"))
        {
            normal = true;
            small = false;
            trackedAlias.localScale += new Vector3(0.8f, 0.8f, 0.8f);
            normalButton.SetActive(true);
            smallButton.SetActive(false);
        }*/
    }
}
