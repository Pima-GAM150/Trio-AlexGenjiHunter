using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupCatch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider e) {
        Destroy(e.gameObject);
    }
}
