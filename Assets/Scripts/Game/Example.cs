using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button portrait, landscape;
    private string nameButon;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        landscape.onClick.AddListener((() => startGame(landscape)));
        portrait.onClick.AddListener((() => startGame(portrait)));


        void TaskOnClick()
        {
            //Output this to console when Button1 or Button3 is clicked
            Debug.Log("You have clicked the button!");
        }

        void TaskWithParameters(string message)
        {
            //Output this to console when the Button2 is clicked
            Debug.Log(message);
        }

        void ButtonClicked(int buttonNo)
        {
            //Output this to console when the Button3 is clicked
            Debug.Log("Button clicked = " + buttonNo);
        }
    }

    void startGame(Button buton)
    {
        nameButon = buton.name;
        Debug.Log("nameButon =  " + nameButon);

        if (nameButon == "Portrait")
        {
            Screen.orientation = ScreenOrientation.Portrait;
            Debug.Log("nameButon =  " + nameButon);
            Debug.Log("ScreenOrientation.Portrait ");
            SceneManager.LoadScene("Game");
            ChendeOrentation.orientations = "Portrait";

        }
        else if (nameButon == "Landscape")
        {
            Screen.orientation = ScreenOrientation.Landscape;

            Debug.Log("creenOrientation.Landscape");
            Debug.Log("nameButon =  " + nameButon);
            ChendeOrentation.orientations = "Landscape";
            SceneManager.LoadScene("GameLandscape");
        }
        
    }
}