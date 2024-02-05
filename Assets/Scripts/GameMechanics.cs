using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameMechanics : MonoBehaviour
{
	public Spawner spawner;
	public GameObject Sword;
    public GameObject targetPosition;
    public float speed, pullBackSpeed;
    bool targetReached;
    private Vector3 startupPosition;
    public AudioClip[] swordSounds;
    private AudioSource audioSource;


	void Start()
    {
        startupPosition = Sword.transform.position;
		audioSource = GetComponent<AudioSource>();
	}

    bool buttonClicked;
    public BoxCollider2D boxcolider2d;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            buttonClicked = true;
			targetReached = false;
            if (spawner.isGameStart==true)
            {
				AudioClip randomSound = swordSounds[Random.Range(0, swordSounds.Length)];
				audioSource.PlayOneShot(randomSound);
			}
			
		}

        if (buttonClicked == true) 
        {
            Sword.transform.position = Vector3.MoveTowards(Sword.transform.position ,targetPosition.transform.position,speed*Time.deltaTime ); 
		}
		if (Sword.transform.position == targetPosition.transform.position)
		{
			targetReached = true;
            buttonClicked = false;
			
		}
        if(targetReached == true)
        {
			Sword.transform.position = Vector3.MoveTowards(Sword.transform.position, startupPosition, pullBackSpeed * Time.deltaTime);
		}


	}

}
