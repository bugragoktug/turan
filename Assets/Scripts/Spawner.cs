using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Spawner : MonoBehaviour
{

    public float minTime,maxTime;
    public bool isGameStart;
    public void StartGame()
    {
        isGameStart = true;
    }
	public void EndGame()
	{
        Application.Quit();
	}
    
	
	void Update()
    {
        if (isGameStart == true && objectSpawnerCoroutine ==null)
        {
           objectSpawnerCoroutine= StartCoroutine(objectSpawner(Random.Range(minTime,maxTime)));
        }
    }
    Coroutine objectSpawnerCoroutine;
    public GameObject[] cntys;
    IEnumerator objectSpawner(float time)
    {
        int randomNum = Random.Range(0, cntys.Length);
        GameObject cntr = Instantiate(cntys[randomNum],gameObject.transform.position + new Vector3(Random.Range(0.06f, 2.2f),0,0), Quaternion.identity);
        Destroy(cntr,1.25f);
        yield return new WaitForSeconds(time);
        objectSpawnerCoroutine = null;
    }


}
