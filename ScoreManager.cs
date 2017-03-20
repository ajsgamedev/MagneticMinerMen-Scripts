using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ScoreManager : MonoBehaviour
{
	public static double score = 0;        // The player's score.
	private double currentTime;
	Text text;                      // Reference to the Text component.

	void Awake ()
	{
		currentTime = 0.0f;
		// Set up the reference.
		text = GetComponent <Text> ();

		// Reset the score.
		score = 0;
	}


	void Update ()
	{
		score = Math.Round (score, 2);
		text.text = "Oil Found: " + score + " GAL";
	}
}