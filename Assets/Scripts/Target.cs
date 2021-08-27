using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int targetType;
    public int score;
    public AudioClip soundHit;
    public GameObject eSlice;
    public GameObject dSlice;

    void Start() {

    }
    void Update() {

    }
    void OnTriggerEnter(Collider other) {
        if (other.GetComponent<Cleaver>()) {
            AudioSource source = GetComponent<AudioSource>();
            source.PlayOneShot(soundHit);
            Cleaver cleaver = other.GetComponent<Cleaver>();
            if (targetType == 0) {
                cleaver.stick();
            } else if (targetType == 1) {
                Data.fail = true;
                cleaver.stick();
            } else if (targetType == 2) {
                Vector3 position = transform.position;
                position.z += 2;
                Rigidbody rbe = Instantiate(eSlice, position, transform.rotation).GetComponent<Rigidbody>();
                rbe.AddForce(new Vector3(0, 0, 500));
                position.z -= 4;
                Rigidbody rbd = Instantiate(dSlice, position, transform.rotation).GetComponent<Rigidbody>();
                rbd.AddForce(new Vector3(0, 0, -500));
                Data.stageScore += score;
                Destroy(gameObject);
            } else if (targetType == 3) {
                Data.stageScore *= score;
                Data.win = true;
                cleaver.stick();
            }
        }
    }
}