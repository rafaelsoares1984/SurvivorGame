﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCamera : MonoBehaviour {

	public GameObject player ;
	private Vector3 distance;

	// Use this for initialization
	void Start (){
		distance = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update (){
		transform.position = player.transform.position + distance;
	}
}
