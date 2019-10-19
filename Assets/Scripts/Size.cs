using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{
    //public GameObject lights;
    private bool large;
    private bool small;
    private bool normal;
    public GameObject roof;
    public Transform trackedAlias;

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
            Vector3 test = trackedAlias.localPosition;
            
            normal = false;
            large = true;
            trackedAlias.localScale += new Vector3(5, 5, 5);
            trackedAlias.localPosition = new Vector3(-7, test.y, 20);
            roof.SetActive(false);
        }
        else if (large == true && Input.GetKeyDown("l"))
        {
            Vector3 test = trackedAlias.localPosition;

            normal = true;
            large = false;
            trackedAlias.localScale -= new Vector3(5, 5, 5);
            trackedAlias.localPosition = new Vector3(0, test.y, 0);
            roof.SetActive(true);

            //trackedAlias.localPosition = new Vector3(-7, 0, 20);
        }
        else if (normal == true && Input.GetKeyDown("l"))
        {
            normal = false;
            small = true;
            trackedAlias.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
        }
        else if (small == true && Input.GetKeyDown("b"))
        {
            normal = true;
            small = false;
            trackedAlias.localScale += new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}
