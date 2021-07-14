using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChendeOrentation : MonoBehaviour
{
    public GameObject Potriat;

    public GameObject Landscape;

    public static string orientations;

    // Start is called before the first frame update
    void Start()
    {
        setOrentation();
    }



    // Update is called once per frame
    private void Update()
    {
        setOrentation();
    }
    
    private void setOrentation()
    {
        Debug.Log("orientations = " + orientations);

        if (orientations == "Landscape")
        {
            Potriat.SetActive(false);
            Landscape.SetActive(true);

            Screen.orientation = ScreenOrientation.Landscape;
        }
        else if (orientations == "Portrait")
        {
            Potriat.SetActive(true);
            Landscape.SetActive(false);
            Screen.orientation = ScreenOrientation.Portrait;
        }
    }
}