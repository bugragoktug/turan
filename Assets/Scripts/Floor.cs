using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
	public ScoreObj scoreObject;
	public AudioClip killsound, deathsound;
	private AudioSource audioSource;
	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}
	private void OnTriggerEnter2D(Collider2D killedObject)
	{
		if (killedObject.gameObject.CompareTag("enemy"))
		{
			scoreObject.EndGame();
			Destroy(killedObject.gameObject);
			audioSource.PlayOneShot(deathsound);
			Time.timeScale = 0;

		}
		else if (killedObject.gameObject.CompareTag("ally"))
		{
			scoreObject.scorePlus();
			Destroy(killedObject.gameObject);
			audioSource.PlayOneShot(killsound);
		}
	}
}
