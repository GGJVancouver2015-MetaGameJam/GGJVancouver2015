using UnityEngine;
using System.Collections;

public class WarningZoneMusic : MonoBehaviour {

	public AudioSource ActionBGM, CalmBGM;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" &&(ActionBGM.audio.isPlaying == false)) {
						CalmBGM.audio.Pause ();
						ActionBGM.audio.Play ();
				} 
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Player") {
			ActionBGM.audio.Pause ();
			CalmBGM.audio.Play ();
		} 
	}

}
