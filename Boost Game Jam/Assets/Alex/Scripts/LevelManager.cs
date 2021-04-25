using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	private PlayerLife player;
	public GameObject start;
	public float TimeToDisplay=2;
	// Use this for initialization
	void Start ()
	{

		start.SetActive(true);
		player = FindObjectOfType<PlayerLife>();

	}

	// Update is called once per frame
	void Update () {
		if (PlayerLife.life == 0) {
			RespawnPlayer ();
		}

		TimeToDisplay=TimeToDisplay- Time.deltaTime;

		//if (Input.GetKey("escape")) 
		//	{
		//	Application.LoadLevel("Menu");
		//}
if (TimeToDisplay<=0)
{
	start.SetActive(false);
}

	}

	public void RespawnPlayer()
	{
		Debug.Log("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
		PlayerLife.life = 1;
		//player.enable ();
	}
}
