using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {

	public GameObject playerShip;

	float playLScale = 1.0f;
	float playRScale = 1.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ( playerShip.tag == "PlayL" && Input.GetMouseButtonDown(0))
		{
			playLScale *= -1.0f;
			transform.localScale = new Vector3 ( playLScale,1.0f,1.0f); 
			//transform.localScale.x = playLScale;
		}

		if (playerShip.tag == "PlayR" && Input.GetMouseButtonDown(1))
		{
			playRScale *= -1.0f;
			transform.localScale = new Vector3 ( playRScale,1.0f,1.0f); 

			//transform.localScale.x = playRScale;
		}
			
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Rock")
		{
			DestroyObject (this.gameObject);
		}
	}
		
}
