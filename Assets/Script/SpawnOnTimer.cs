﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnTimer : MonoBehaviour {
    public GameObject[] Marbles;//array of marbles to random from
    public GameObject spawnPoint;//empty called spawn point
    private System.Random rng = new System.Random();
    //private List<GameObject> VisibleMarbles = new List<GameObject>();
    private float timer = 5.0f;//timer for respawn
    private float currentTime = 0f;//calculate time passing

    // Use this for initialization
    void Start () {
        nMarble();
	}

    void nMarble() {
        //pick a marble from the list
        int style = 0;
        style = rng.Next(0, Marbles.Length);
        Vector3 pos = spawnPoint.transform.position;
        //add some random rotation;
        Quaternion rot = new Quaternion();
        rot = Quaternion.Euler(rng.Next(0,180), rng.Next(0, 180), rng.Next(0,180));
        //instantiate and add to list
        GameObject nMarble = (GameObject)Instantiate(Marbles[style], pos, rot, transform);
        //change below to work with object pooling when created
        //VisibleMarbles.Add(nMarble);
    }
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if (currentTime >= timer) {
            currentTime = 0.0f;
            nMarble();
        }
	}
}
