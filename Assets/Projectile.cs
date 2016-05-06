using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
    public float speed = 3.0f;

    private float velocity;
	// Use this for initialization
	void Start () {
        velocity = speed * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () { 
        transform.Translate(0, -velocity, 0);
	}
}
