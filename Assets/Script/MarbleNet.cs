using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleNet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider e) {
        //Destroy(e.gameObject);
        //in preparation for OBJECT POOLING MOTHER FUCKERS
        e.gameObject.SetActive(false);
    }
}
