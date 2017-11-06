using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFlipper : MonoBehaviour, IClickable {

    public GameObject flipToSwitch;
    public float leftSide;
    public float riteSide;
    private bool side = false;
    private Vector3 rotate = new Vector3();

    public void OnClicked(int i) {
        side = !side;
        rotate.z = (side)? riteSide : leftSide;
        flipToSwitch.transform.rotation = Quaternion.Euler(rotate);
    }

	// Use this for initialization
	void Start () {
        rotate.z = (side) ? riteSide : leftSide;
        flipToSwitch.transform.rotation = Quaternion.Euler(rotate);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
