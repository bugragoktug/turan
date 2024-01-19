using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
	public ScoreObj scoreObject;
	private void OnTriggerEnter2D(Collider2D killedObject)
	{
		if (killedObject.gameObject.CompareTag("uk"))

		{
			scoreObject.EndGame();
			Destroy(killedObject.gameObject);
		}
		else if (killedObject.gameObject.CompareTag("ar"))

		{
			scoreObject.EndGame();
			Destroy(killedObject.gameObject);
		}
		else if (killedObject.gameObject.CompareTag("it"))
		{
			scoreObject.EndGame();
			Destroy(killedObject.gameObject);
		}
		else if (killedObject.gameObject.CompareTag("gr"))
		{
			scoreObject.EndGame();
			Destroy(killedObject.gameObject);
		}
		else if (killedObject.gameObject.CompareTag("fr"))
		{
			scoreObject.EndGame();
			Destroy(killedObject.gameObject);
		}
		else if (killedObject.gameObject.CompareTag("TR"))
		{
			scoreObject.scorePlus();
			Destroy(killedObject.gameObject);
		}
	}
}
