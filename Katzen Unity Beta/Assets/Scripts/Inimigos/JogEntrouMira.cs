﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogEntrouMira : MonoBehaviour {

	public bool jogEntrou;

    public GameObject player;

	// Use this for initialization
	void Start () {
		jogEntrou = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag("Player"))
		{
			jogEntrou = true;
            player = col.gameObject;

        }
	}

	private void OnTriggerExit(Collider col)
	{
		if (col.CompareTag("Player"))
		{
			jogEntrou = false;
            player = null;
		}
	}
}
