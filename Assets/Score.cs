using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
public BirdPlayer player;
private Text thisText;
	// Use this for initialization
	void Start () {
		thisText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		thisText.text = "ОЧКИ: " + player.score;
	}
}
