using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
	public KeyCode moveUp;
	public KeyCode moveDown;
	public float speed = 10f;

	private void SetVelocity(float speed) {
		this.rigidbody2D.velocity = new Vector2(this.rigidbody2D.velocity.x, speed);
	}
	
	void Update () {
		float speed = 0f;
		if (Input.GetKey (this.moveUp)) {
			speed = this.speed;
		}
		else if (Input.GetKey (this.moveDown)) {
			speed = -this.speed;
		}
		this.SetVelocity(speed);
	}
}
