using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

	// make game manager public static so can access this from other scripts
	public static GameManager gm;

	//public AudioSource crowd;
	public AudioSource song;
	/*public AudioSource boo;
	public AudioSource cheer;
	public AudioSource loseSound;*/

	public GameObject extraSpawner1;
	public GameObject extraSpawner2;

	public GameObject Lose;
	public GameObject ResetGame;
	//public GameObject ExitGame;
	public GameObject RockSpawners;
	public GameObject Player;


	AudioSource music;
	private double currentTime;
	private double finalScore;

	void Awake ()
	{
		Time.timeScale = 1;
		Lose.SetActive (false);
		ResetGame.SetActive (false);
		extraSpawner1.SetActive (false);
		extraSpawner2.SetActive (false);

		RockSpawners.SetActive (true);
		Player.SetActive (true);
	}

	// setup the game
	void Start ()
	{
		
		// get a reference to the GameManager component for use by other scripts
		if (gm == null)
			gm = this.gameObject.GetComponent<GameManager> ();

	}

	// this is the main game event loop
	void Update ()
	{
		currentTime += (Time.deltaTime * 0.12);
		if ( GameObject.FindGameObjectWithTag("PlayL")==false && GameObject.FindGameObjectWithTag("PlayR")==false)
		{
			BadEndGame ();
		}
		else
		{
			ScoreManager.score = currentTime;
			if (ScoreManager.score > 3)
			{
				extraSpawner1.SetActive (true);
			}

			if (ScoreManager.score > 5)
			{
				extraSpawner2.SetActive (true);
			}
		}

	}
		

	public void BadEndGame ()
	{
		// game is over
		finalScore = currentTime;
		Lose.SetActive (true);
		ResetGame.SetActive (true);

		Time.timeScale = 0;
		RockSpawners.SetActive (false);
		Player.SetActive (false);

		ScoreManager.score = finalScore;
		//crowd.volume = 0.1f;
		song.volume = 0.3f;
		song.pitch = 0.8f;
	}

	public void ResetLevel ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}


	// public function that can be called to exit the game
	public void ReturnToMainMenu ()
	{
		
		SceneManager.LoadScene ("MainMenu");

	}
		

}
