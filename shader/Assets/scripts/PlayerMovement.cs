using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float speed;
	public Rigidbody rigidBody;
	public Vector3 movement;
	void Awake()
	{
		rigidBody = GetComponent<Rigidbody> ();
}

	void Update(){

		if (Input.GetKeyDown  (KeyCode.Space)) {
			rigidBody.AddForce (0, 200, 0);
		}



		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		movement = new Vector3 (x, 0, z);

		if (transform.position.y <= -90) {
			Debug.Log ("lol");
			Application.LoadLevel ("menu");
		}
	


	}
	void FixedUpdate()
	{
		rigidBody.AddForce (movement.normalized * speed);
	
		}
}
