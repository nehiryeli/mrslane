﻿using UnityEngine;
using System.Collections;

public class DemoCamMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3(Time.deltaTime * 3, 0, 0);
	}
}
