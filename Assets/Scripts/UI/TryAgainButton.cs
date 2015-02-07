using UnityEngine;
using System.Collections;

public class TryAgainButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void Execute()
	{
		Application.LoadLevel( "Start" );
	}


}
