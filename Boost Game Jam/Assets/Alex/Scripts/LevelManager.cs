using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	private PlayerLife player;
	// Use this for initialization
	void Start ()
	{
		
		player = FindObjectOfType<PlayerLife>();

	}

	// Update is called once per frame
	void Update () {
		if (PlayerLife.life == 0) {
			RespawnPlayer ();
		}

		//if (Input.GetKey("escape")) 
		//	{
		//	Application.LoadLevel("Menu");
		//}
	}

	public void RespawnPlayer()
	{
		Debug.Log("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
		PlayerLife.life = 1;
		//player.enable ();
	}
}
