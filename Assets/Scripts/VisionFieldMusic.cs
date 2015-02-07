using UnityEngine;
using System.Collections;

public class VisionFieldMusic : MonoBehaviour {

	public AudioSource VisionFieldSFX, SpottedSFX;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			VisionFieldSFX.Play();
			SpottedSFX.Play ();
		} 
	}
	


}
