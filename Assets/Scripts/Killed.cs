    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killed : MonoBehaviour
{
	public ScoreObj scoreObject; 
	public AudioClip killsound, deathsound;
	private AudioSource audioSource;
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}
	public void openSword()
	{
		gameObject.SetActive(true);
	}
	private void OnTriggerEnter2D(Collider2D killedObject)
	{
		if (killedObject.gameObject.CompareTag("enemy"))
		{
			scoreObject.scorePlus();
			Destroy(killedObject.gameObject);
			audioSource.PlayOneShot(killsound);


		}
		else if (killedObject.gameObject.CompareTag("ally"))
		{
			scoreObject.EndGame();
			Destroy(killedObject.gameObject);
			audioSource.PlayOneShot(deathsound);
			Time.timeScale = 0;
			
		}
	}
}
