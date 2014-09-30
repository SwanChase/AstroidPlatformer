using UnityEngine;
using System.Collections;

public class DestroyByBoundry : MonoBehaviour 
{
	public GUIText scoreText;
	public GUIText waveText;
	private int score;
	private int wave;
	private int waveCounter;

	void Start()
	{
		wave = 0;

		score = 0;
		setScoreText ();
	}

	void OnTriggerExit(Collider other)
	{
		score++;
		waveCounter++;
		setScoreText ();
		Destroy(other.gameObject);
	}
	void setScoreText()
	{
		scoreText.text = "Score: " + score.ToString ();
		if(waveCounter ==10)
		{
			waveCounter = 0;
			wave++;
			waveText.text = "wave: " + wave.ToString ();
		}

	}
}
