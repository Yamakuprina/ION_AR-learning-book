using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {
public Transform Cam;
	// Use this for initialization
	void Start () {
		Cam = GameObject.Find("ARCamera").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(Cam);
	}
}
