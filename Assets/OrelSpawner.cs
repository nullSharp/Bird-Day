using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrelSpawner : MonoBehaviour {
private bool spawnOrel = true;
public GameObject orel,sparrow,parrot;
public List<Transform>positions = new List<Transform>();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(spawnOrel)
		{
		StartCoroutine(Spawn());
		}
	}
	IEnumerator Spawn()
	{
	spawnOrel = false;
	yield return new WaitForSeconds(2.5f);
	Instantiate(orel,positions[Random.Range(1,8)].position,Quaternion.identity);
	Instantiate(sparrow,positions[Random.Range(1,8)].position,Quaternion.identity);
	Instantiate(sparrow,positions[Random.Range(1,8)].position,Quaternion.identity);
	Instantiate(parrot,positions[Random.Range(1,8)].position,Quaternion.identity);
	spawnOrel = true;
	}
}
