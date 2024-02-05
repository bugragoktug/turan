using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreObj : MonoBehaviour
{
	public Spawner spawner;
	public GameObject gameOverMenu;
	public int score;
	public TMP_Text scoreObject ,scoretext, highscoretext , buttontext;	
	public int scorePlus()
	{
		score++;	
		scoreObject.text = score.ToString();
		
		return score;
	}
	public void resetScore()
	{
		score = 0;
		scoreObject.SetText("0");

	}
	public void Start()
	{
		scoreObject.SetText("0");
		highscoretext.SetText(PlayerPrefs.GetInt("score").ToString());
	}



	public void EndGame() {
		if (PlayerPrefs.GetInt("score") < score)
		{
			PlayerPrefs.SetInt("score", score);
		}
	
		buttontext.SetText("Try Again");
		scoretext.SetText(score.ToString());
		highscoretext.SetText(PlayerPrefs.GetInt("score").ToString());
		gameOverMenu.SetActive(true);
		spawner.isGameStart = false;
	}
}
