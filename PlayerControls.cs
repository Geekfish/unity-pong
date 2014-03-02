using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
	public KeyCode moveUp;
	public KeyCode moveDown;
	public float speed = 10F;

	private void SetVelocity(float speed) {
		//Vector2 new_velocity = new Vector2(this.rigidbody2D.velocity.x, speed);
		this.rigidbody2D.velocity = new Vector2(this.rigidbody2D.velocity.x, speed);
	}
	
	void Update () {
		if (Input.GetKey (this.moveUp)) {
			this.SetVelocity(this.speed);
		}
		else if (Input.GetKey (this.moveDown)) {
			this.SetVelocity(-this.speed);
		}
		else {
			this.SetVelocity(0F);
		}
	}
}
