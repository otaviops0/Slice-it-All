using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GUIGame : MonoBehaviour {
    public Text txtScore;
    void Update() {
        txtScore.text = Convert.ToString(Data.savedScore + Data.stageScore);
    }
}
