using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUIScript : MonoBehaviour {
    public void SendMessage(string message) {
        if (message == "newGame")
        {
            Data.stage = 1;
            Data.savedScore = 0;
            openStage();
        }
        else if (message == "next")
        {
            Data.stage++;
            openStage();
        }
        else if (message == "menu") {
            SceneManager.LoadScene("Screens");
        }
        else if (message == "restart") {
            Data.stageScore = 0;
            Data.win = false;
            Data.fail = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    static public void openStage() {
        Data.stageScore = 0;
        Data.win = false;
        Data.fail = false;
        switch (Data.stage) {
            case 1:SceneManager.LoadScene("Stage1");break;
            case 2: SceneManager.LoadScene("Stage2"); break;
            default: SceneManager.LoadScene("Screens"); break;
        }
    }
}
