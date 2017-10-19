﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleableObject : MonoBehaviour, IClickable {


    bool toggle = true;
    Vector3 pos;
    float speed = 5;

    public void Start() {
        pos = gameObject.transform.position;
    }

    public void Update() {
        if (toggle) moveTowards(pos);
        else if (!toggle) moveTowards(pos);
    }

	public void OnClicked( int clickedWithButton) {
        if (toggle) {
            toggle = false;
            getPos(new Vector3(5, 0, 0));
        }
        else {
            toggle = true;
            getPos(new Vector3(-5, 0, 0));
        }
    }

    public void moveTowards(Vector3 pos) {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, pos, Time.deltaTime);
    }

    public Vector3 getPos(Vector3 direction) {
        pos = gameObject.transform.position + direction;
        return pos;
    }
}