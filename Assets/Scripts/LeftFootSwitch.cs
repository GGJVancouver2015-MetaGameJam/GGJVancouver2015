using UnityEngine;
using System.Collections;

public class LeftFootSwitch : MonoBehaviour {

	public AudioSource L1, L2, L3, L4, L5;

	void PlayLeft() {
		int i = Random.Range (1, 5);
		
		switch(i) {
		case 1:
			L1.audio.Play ();
			
			break;
		case 2:
			L2.audio.Play ();
			break;
		case 3:
			L3.audio.Play ();
			break;
		case 4:
			L4.audio.Play ();
			break;
		case 5:
			L5.audio.Play ();
			break;
		}
	}
}
