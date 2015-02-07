using UnityEngine;
using System.Collections;

public class LaptopDownload : MonoBehaviour {
	public float counter;
	private float fadeTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (counter > 5f) {
			Application.LoadLevel("Level3");		
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			counter += Time.deltaTime;		
		}
		
	}
	
		
}
