    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killed : MonoBehaviour
{
	public ScoreObj scoreObject;
	private void OnTriggerEnter2D(Collider2D killedObject)
	{
		if (killedObject.gameObject.CompareTag("uk"))

		{
			scoreObject.scorePlus();
			Destroy(killedObject.gameObject);	
		}
		else if (killedObject.gameObject.CompareTag("ar"))

		{
			scoreObject.scorePlus();
			Destroy(killedObject.gameObject);
		}
		else if (killedObject.gameObject.CompareTag("it"))
		{
			scoreObject.scorePlus();
			Destroy(killedObject.gameObject);
		}
		else if (killedObject.gameObject.CompareTag("gr"))
		{scoreObject.scorePlus();
			Destroy(killedObject.gameObject);
		}
		else if (killedObject.gameObject.CompareTag("fr"))
		{scoreObject.scorePlus();
			Destroy(killedObject.gameObject);
		}
		else if (killedObject.gameObject.CompareTag("TR"))
		{scoreObject.EndGame();
			Destroy(killedObject.gameObject);
		}
	}
}
