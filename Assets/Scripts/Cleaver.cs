using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaver : MonoBehaviour { 
    public float jumpVelocity;
    public float xVelocity;
    public float gravity;
    public float rotationVelocity;
    private bool sticked = false;
    private Vector3 velocity;
    void Start() {
        velocity = new Vector3(0,0,0);
    }
    void Update() {
        if (Input.GetMouseButtonDown(0) && !Data.fail && !Data.win) {
            sticked = false;
            velocity = new Vector3(xVelocity,jumpVelocity,0);
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }
        if (!sticked) {
            velocity.y -= gravity * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;
            transform.rotation = Quaternion.Euler(-velocity.y*rotationVelocity, 90, 0);

        }
    }
    public void stick() {
        velocity = new Vector3(0, 0, 0);
        sticked = true;
    }
}
