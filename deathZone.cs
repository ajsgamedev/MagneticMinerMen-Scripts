using UnityEngine;
using System.Collections;

public class deathZone : MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "PlayL" | other.gameObject.tag == "PlayR")
		{	
			DestroyObject (other.gameObject);
		}
		else
		{
			
		}	
		
	}
}
