using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public Spawner spawner;
	public bool isMuted = false;
   
    void Update()
    {
        if (spawner.isGameStart==true)
        {
			gameObject.SetActive(true);
		}
		else if (spawner.isGameStart==false)
		{
			gameObject.SetActive(false);
		}
    }
}
