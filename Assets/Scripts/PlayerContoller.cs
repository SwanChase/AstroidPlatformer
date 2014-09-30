using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float moveForce = 365f;
	public float maxSpeed = 5f;
	public float minX, minZ, maxX, maxZ;
}


public class PlayerContoller : MonoBehaviour 
{

	public float speed;
	public float tilt;
	public Boundary boundary;



	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		/*if(moveHorizontal * rigidbody.velocity.x < boundary.maxSpeed)
			//Horizontal
			rigidbody.AddForce(Vector2.right * moveHorizontal * boundary.moveForce);

		if(moveVertical * rigidbody.velocity.x < boundary.maxSpeed)
			//Vertical
			rigidbody.AddForce(Vector2.right * moveVertical * boundary.moveForce);

		if(Mathf.Abs(rigidbody.velocity.z) > boundary.maxSpeed)

			rigidbody.velocity = new Vector2(Mathf.Sign(rigidbody.velocity.x) * boundary.maxSpeed, rigidbody.velocity.y);

		if(Mathf.Abs(rigidbody.velocity.z) > boundary.maxSpeed)
			
			rigidbody.velocity = new Vector2(Mathf.Sign(rigidbody.velocity.z) * boundary.maxSpeed, rigidbody.velocity.y);
		*/

		Vector3 thrust = new Vector3 (
			moveHorizontal,
			0f,
			moveVertical);

		rigidbody.AddForce (thrust * speed);

		rigidbody.position = new Vector3
		(
			Mathf.Clamp (rigidbody.position.x, boundary.minX, boundary.maxX),
			0.0f,
			Mathf.Clamp (rigidbody.position.z, boundary.minZ, boundary.maxZ)
		);
		rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.x * -tilt);
	}
}
