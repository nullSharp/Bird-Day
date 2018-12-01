using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {
	public GameObject worm;
	private bool spawn = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(spawn){
			StartCoroutine(Spawn());
		}
	}
	IEnumerator Spawn()
	{
		spawn = false;
	yield return new WaitForSeconds(1);
Instantiate(worm,new Vector2(Random.Range(-5.82f,10),-3.69f),Quaternion.identity);
	    spawn = true;
	}
}
