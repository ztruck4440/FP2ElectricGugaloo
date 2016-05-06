﻿using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
    public float speed = 3.0f;
    public float timer = 5.0f;

    private float velocity;
	// Use this for initialization
	void Start () {
        velocity = speed * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        transform.Translate(0, -velocity, 0);

        if (timer < 0.0f)
        {
            Destroy(this.gameObject);
        }
	}
}
