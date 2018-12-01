using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour {
	[SerializeField] private bool isSource;
private bool doSomething = true;
private Vector2 firstPosition;
private bool followToBird = false;
[SerializeField]private GameObject bird;
public BirdPlayer player;
	// Use this for initialization
	void Start () {
		
		bird = GameObject.Find("bird");
		firstPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate(-2 * Time.deltaTime,0,0);
	if(followToBird)
	{
	transform.position = bird.transform.position;
	}
	}
	void OnTriggerEnter2D(Collider2D c)
	{
	if(c.gameObject.tag=="bird")
	{
followToBird = true;
    }
	if(c.gameObject.tag=="eggs")
	{
		player.score++;
    Destroy(gameObject);
	}
	}
	
}
