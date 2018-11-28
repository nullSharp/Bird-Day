using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPlayer : MonoBehaviour {
	private bool canFly=true;
private float speed = 2.5f;
private Rigidbody2D player_rigidbody;
private int direction;// 1 - вправо, -1 - влево
private SpriteRenderer spriteBird;
public Sprite simpleSprite;
	// Use this for initialization
	void Start () {
		spriteBird = GetComponent<SpriteRenderer>();
		player_rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if(direction == 1)
		{
		spriteBird.flipX = false;
		}
		if(direction == -1)
		{
		spriteBird.flipX = true;
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
		direction = -1;
		}
		 if(Input.GetKeyDown(KeyCode.RightArrow))
		{
		direction = 1;
		}
		transform.Translate(direction*speed* Time.deltaTime,0,0);
		if(canFly)
		{
		if(Input.GetKeyDown(KeyCode.X))
		{
	StartCoroutine(Rot());
		}
		}
	}
	IEnumerator Rot()
	{
		canFly = false;
		if(spriteBird.flipX)
		{
		transform.Rotate(0,0,-15);
		player_rigidbody.velocity = new Vector2(player_rigidbody.velocity.x,4);
		yield return new WaitForSeconds(0.2f);
transform.rotation = new Quaternion(0,0,0,1);
		}
		if(!spriteBird.flipX)
		{
		transform.Rotate(0,0,15);
		player_rigidbody.velocity = new Vector2(player_rigidbody.velocity.x,4);
		yield return new WaitForSeconds(0.2f);
transform.rotation = new Quaternion(0,0,0,1);
		}
		canFly = true;
	}
}
