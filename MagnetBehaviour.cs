using UnityEngine;
using System.Collections;

public class MagnetBehaviour : MonoBehaviour {

	public GameObject centerPoint;
	public GameObject player;
	Rigidbody2D rb;
	bool push = false;
	// Use this for initialization
	void Start () 
	{
		rb = player.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerStay2D(Collider2D col)
	{
		if (col.gameObject.tag == this.gameObject.tag)
		{
				
				rb.MovePosition (transform.position - transform.up * Time.deltaTime);

		}
		else
		{
				rb.MovePosition (transform.position + transform.up * Time.deltaTime);
				
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == this.gameObject.tag)
		{
				
				rb.MovePosition (transform.position - transform.up * Time.deltaTime);

		}
		else
		{
				rb.MovePosition (transform.position + transform.up * Time.deltaTime);
				
		}
		push = false;
	}

	/*void OnTriggerExit2D(Collider2D col)
	{
		push = true;
	}*/
		
}
