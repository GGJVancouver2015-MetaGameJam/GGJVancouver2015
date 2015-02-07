using UnityEngine;
using System.Collections;

public class MoveMain : MonoBehaviour {
	

	public float speed = 1.0f;
	public string CollideWithSecurityLevel = "LoseUI";
	public string CollideWithWin = "WinUI";
	protected Animator animator;



	void Start() {
		animator = this.transform.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
	
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		//transform.Rotate (0, 0, Input.GetAxis("Vertical"));
		//transform.Rotate(0, 0, Time.deltaTime * 30, Space.Self); 
		//transform.Rotate (0, 0, Input.GetAxis("Horizontal"));

		transform.position += move * speed * Time.deltaTime;

		if (Input.GetAxis ("Horizontal") > 0 && Input.GetAxis ("Vertical") > 0)
			transform.rotation = Quaternion.AngleAxis(135, Vector3.forward);
		else if (Input.GetAxis ("Horizontal") > 0 && Input.GetAxis ("Vertical") < 0)
			transform.rotation = Quaternion.AngleAxis(45, Vector3.forward);
		else if (Input.GetAxis ("Horizontal") < 0 && Input.GetAxis ("Vertical") > 0)
			transform.rotation = Quaternion.AngleAxis(225, Vector3.forward);
		else if (Input.GetAxis ("Horizontal") < 0 && Input.GetAxis ("Vertical") < 0)
			transform.rotation = Quaternion.AngleAxis(315, Vector3.forward);
		else if (Input.GetAxis ("Horizontal") > 0)
			transform.rotation = Quaternion.AngleAxis(270, Vector3.forward);
		else if (Input.GetAxis ("Horizontal") < 0)
			transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
		else if (Input.GetAxis ("Vertical") > 0)
			transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
		else if (Input.GetAxis ("Vertical") < 0)
			transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
	
		if (animator) {

				if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) 
					animator.SetBool("Walking", true );
				else
					animator.SetBool("Walking", false);                
			}


	}




	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Security")
			Application.LoadLevel(CollideWithSecurityLevel);

		if (other.gameObject.tag == "WinCond")
			Application.LoadLevel(CollideWithWin);

	
	}




}



