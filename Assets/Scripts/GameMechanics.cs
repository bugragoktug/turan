using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechanics : MonoBehaviour
{
    public GameObject Sword;
    public GameObject targetPosition;
    public float speed , pullBackSpeed;
    bool targetReached;
    private Vector3 startupPosition;


	void Start()
    {
        startupPosition = Sword.transform.position;
    }

    bool buttonClicked;
    public BoxCollider2D boxcolider2d;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            buttonClicked = true;
			targetReached = false;
            
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
