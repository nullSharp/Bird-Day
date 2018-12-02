using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrot : MonoBehaviour {
private float speed = 3f;
private int i = 0;
[SerializeField] private Transform player;
[SerializeField] private GameObject lashara;
float angle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 transform.position = Vector2.MoveTowards(transform.position,player.position,2 * Time.deltaTime);
		 Vector2 difference = player.position - transform.position;
		 difference.Normalize();
		 float rot = Mathf.Atan2(difference.y,difference.x) * Mathf.Rad2Deg;
		 transform.rotation = Quaternion.Euler(0,0,rot);
		     canshoot = false;
        A = new Vector2(player.transform.position.x, player.transform.position.y);
        B = new Vector2(transform.position.x, transform.position.y);
        C = A - B;
        angle_bullet = Mathf.Atan2(C.x, C.y);
        speed = new Vector2(Mathf.Sin(angle_bullet) , Mathf.Cos(angle_bullet));
       GameObject bul = Instantiate(bullet, transform.position, Quaternion.identity);
        bul.GetComponent<Rigidbody2D>().AddForce(speed * 6,ForceMode2D.Impulse);
	i++;
	if(i >= 1000)
	{
	Destroy(gameObject);
	}
	Invoke("CreateLashara",2f);
	}
	void CreateLashara(){
	var a = Instantiate(lashara,transform.position,Quaternion.identity);
    Vector2 a = player.position;
	Vector2 b = transform.position;
	Vector2 c = a - b;
	angle = Mathf.Atan2(c.x,c.y) * 
	}
}
