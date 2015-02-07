using UnityEngine;
using System.Collections;

public class DeleteText : MonoBehaviour {
	float counter = 0;
	// Use this for initialization
	void Start () {

			counter += Time.deltaTime;

	}
	
	// Update is called once per frame
	void Update () {
		if (counter > 5f)
						Destroy (gameObject);
	}
}
