using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GUIWin : MonoBehaviour {
    public Text txtStageScore;
    void Start() {
        
    }
    void Update() {
        txtStageScore.text = Convert.ToString(Data.stageScore);
    }
    public void SendMessage(string message)
    {
        if (message == "next") {
            Data.savedScore += Data.stageScore;
            Data.stage++;
            if (Data.stage == 1)
            {
                GUIScript.openStage();
            }
            else
            {
                SceneManager.LoadScene("Screens");
            }
        }
    }
}
