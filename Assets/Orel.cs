using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orel : MonoBehaviour {
private int i = 0;
public GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("bird");
	}
	void RotateFunc()
	{
	        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 2 * Time.deltaTime);
	        Vector2 difference = player.transform.position - transform.position;
			difference.Normalize();
			float rot = Mathf.Atan2(difference.y,difference.x) * Mathf.Rad2Deg;
			        transform.rotation = Quaternion.Euler(0f, 0f, rot);    
	}
	// Update is called once per frame
	void Update () {
		RotateFunc();
	i++;
	if(i >= 1000)
	{
	Destroy(gameObject);
	}
	}
}
