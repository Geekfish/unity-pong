using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {
	public Camera mainCam;
	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;

	public Transform player01;
	public Transform player02;

	// Use this for initialization
	void Start () {
	
	}

	private void PositionWalls() {
		this.topWall.size = new Vector2 (
			this.mainCam.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x, 1f);
		this.topWall.center = new Vector2 (
			0f, this.mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y + 0.5f);
		
		this.bottomWall.size = new Vector2 (
			this.mainCam.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x, 1f);
		this.bottomWall.center = new Vector2 (
			0f, this.mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y - 0.5f);
		
		this.leftWall.size = new Vector2 (
			this.mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).x, 1f);
		this.leftWall.center = new Vector2 (
			this.mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y + 0.5f, 0f);
		
		this.rightWall.size = new Vector2 (
			this.mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).x, 1f);
		this.rightWall.center = new Vector2 (
			this.mainCam.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).y + 0.5f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		this.player01.position = new Vector2(
			this.mainCam.ScreenToWorldPoint (new Vector3 (75f, 0f, 0f)).x,
			this.player01.position.y);
		this.player02.position = new Vector2(
			this.mainCam.ScreenToWorldPoint (new Vector3 (Screen.width - 75f, 0f, 0f)).x,
			this.player02.position.y);

	}
}
