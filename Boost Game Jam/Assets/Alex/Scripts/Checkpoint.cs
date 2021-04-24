using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
	SpriteRenderer render;
	public Sprite exchange3;

	public LevelManager levelManager;

	void Start()
	{
		levelManager = FindObjectOfType<LevelManager>();
		render = GetComponent<SpriteRenderer>();

	}

	void FixedUpdate()
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			levelManager.currentCheckpoint = gameObject;

			render.sprite = exchange3;
	
		}
}
}
