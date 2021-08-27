using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public Cleaver cleaver;
    public GameObject screenGameOver;
    public GameObject screenWin;
    void Start()
    {
        
    }
    void Update() {
        transform.position = new Vector3(cleaver.transform.position.x, cleaver.transform.position.y + 3, cleaver.transform.position.z - 25);
        if (Data.fail) {
            screenGameOver.SetActive(true);
        }
        if (Data.win) {
            screenWin.SetActive(true);
        }
    }
}
