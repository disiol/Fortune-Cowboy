using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartGame : MonoBehaviour

{
    public Button portrait;
    public Button landscape;
    private string nameButon;
    //
    // // Start is called before the first frame update
    // void Start()
    // {
    //     Button btn = portrait.GetComponent<Button>();
    //     Button btn2 = landscape.GetComponent<Button>();
    //     portrait.onClick.AddListener(startGame(btn));
    //     btn2.onClick.AddListener(startGame(btn2));
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }
    //
    // private  void startGame(Button buton)
    // {
    //
    //      nameButon = buton.name;
    //      Debug.Log("nameButon =  " + nameButon);
    //
    //     if (nameButon == "Portrait")
    //     {
    //         Screen.orientation = ScreenOrientation.Portrait;
    //         Debug.Log("nameButon =  " + nameButon);
    //         Debug.Log("ScreenOrientation.Portrait ");
    //         SceneManager.LoadScene("Game");
    //     }
    //     else if (nameButon == "Landscape")
    //     {
    //         Screen.orientation = ScreenOrientation.Landscape;
    //
    //         Debug.Log("creenOrientation.Landscape");
    //         Debug.Log("nameButon =  " + nameButon);
    //         Orentation.orientations = "Landscape";
    //         SceneManager.LoadScene("Game");
    //     }
    //
    // }
    //
    //
}
