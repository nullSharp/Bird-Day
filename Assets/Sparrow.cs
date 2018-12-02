using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparrow : MonoBehaviour {
[SerializeField] private int direction;
private SpriteRenderer sprite;
	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(direction == 1)
		{
		sprite.flipX = false;
        transform.Translate(1 * Time.deltaTime,0,0);
		}
		if(direction == -1)
		{
			sprite.flipX = true;
		transform.Translate(-1 * Time.deltaTime,0,0);
		}
	}
}
