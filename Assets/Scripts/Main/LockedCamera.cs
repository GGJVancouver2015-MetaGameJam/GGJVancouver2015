using UnityEngine;
using System.Collections;

public class LockedCamera : MonoBehaviour {


	public Transform target;
	public float smoothing = 4f;

	Vector3 offset, mouseOffset;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.position;
		//mouseOffset = new Vector3 (-169.69f, 5.89f, -5f);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetCamPos = target.position + offset;
		/*Vector3 mouseCamPos;
		mouseCamPos.y = Input.mousePosition.y;
		mouseCamPos.x = 0;
		mouseCamPos.z = -5f;*/

		if (targetCamPos.x < -23.43f)
			targetCamPos.x = -23.43f;
		else if (targetCamPos.x > -16.57f)
			targetCamPos.x = -16.57f;

		if (targetCamPos.y < -14.1f)
			targetCamPos.y = -14.1f;
		else if (targetCamPos.y > 8.06f)
			targetCamPos.y = 8.06f;
		

		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);

		/*if(Input.GetMouseButton(0))
			transform.position = Camera.main.ScreenToWorldPoint(mouseCamPos);*/
	}
}
