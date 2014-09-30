using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{

	public GameObject Droplets;
	public Vector3 spawnValues;
	public int DropletCount;
	public float startWait;
	public float spawnWait;
	public float waveWait;

	void Start () 
	{
		StartCoroutine (SpawnWaves ());
	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			print("space key was pressed");
			Application.LoadLevel(Application.loadedLevelName);
		}
	}
	IEnumerator SpawnWaves () 
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < DropletCount; i++) 
			{
				Vector3 spawnPostition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (Droplets, spawnPostition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds(waveWait);	
		}
	}
}
