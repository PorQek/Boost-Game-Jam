using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int Points;
    public AudioClip CoinBoing;
	public AudioSource Source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
		{
		if (other.tag=="Player") {

            Debug.Log("coin");
            Source.PlayOneShot(CoinBoing);
            Bank.score=Bank.score + Points;
            Destroy(gameObject);
            
        }
}
}
