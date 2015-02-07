using UnityEngine;
using System.Collections;

public class RightFootSwitch : MonoBehaviour {

	public AudioSource R1, R2, R3, R4, R5;
	
	void PlayRight() {

		int i = Random.Range (1, 5);

		switch(i) {
			case 1:
			R1.audio.Play ();

			break;
			case 2:
			R2.audio.Play ();
			break;
			case 3:
			R3.audio.Play ();
			break;
			case 4:
			R4.audio.Play ();
			break;
			case 5:
			R5.audio.Play ();
			break;
		}


		
	}
}
