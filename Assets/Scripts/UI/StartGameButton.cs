﻿using UnityEngine;
using System.Collections;

public class StartGameButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void Execute()
	{
		Application.LoadLevel( "Level1" );
	}


}
