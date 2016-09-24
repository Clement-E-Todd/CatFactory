using UnityEngine;
using System.Collections;

public class CatSpawner : MonoBehaviour {

	const float spawnDistanceX = -9f;
	const float minSpawnDistanceY = -4f;
	const float maxSpawnDistanceY = 4f;

	//Minimum 'elasped' time between cat spawns (subject to change) 
	const float initialMinPauseTime = 1.5f;
	//Maximum 'elapsed' time between cat spawns (subject to change);
	const float initialMaxPauseTime = 3f;
	//Represents minimum possible change in spawn time per difficulty level raise.
	const float minPauseTimePerDifficulty = -0.05f;
	//Represents maximum possible change in spawn time per difficulty level raise.
	const float maxPauseTimePerDifficulty = -0.1f;
	//Hard limit to how little time should pass between cat spawns.
	const float absoluteMinPauseTime = 0.25f;
	//Smallest allowed difference between maximum and minimum time between spawns.
	const float absoluteMinPauseRange = 0.5f;		

	public float currentDifficulty = 0;


	void Start ()
	{
		SpawnCat();
	}

	void Update ()
	{
	
	}

	void SpawnCat()
	{
		GameObject prefabInstance = Resources.Load<GameObject>("prefabs/Cat");
		GameObject newCat = Instantiate<GameObject>(prefabInstance);

		float yDistance = Random.Range(minSpawnDistanceY, maxSpawnDistanceY);

		newCat.transform.position = transform.position +
			new Vector3(spawnDistanceX, yDistance, -transform.position.z);

		Invoke("SpawnCat", GetPauseTime());
	}

	float spawnPauseTime = 0f;

	float  GetPauseTime()
	{
		float minTime = initialMinPauseTime + (minPauseTimePerDifficulty * currentDifficulty);
		float maxTime = initialMaxPauseTime + (maxPauseTimePerDifficulty * currentDifficulty);

		minTime = Mathf.Max(minTime, absoluteMinPauseTime);
		maxTime = Mathf.Max(maxTime, absoluteMinPauseTime + absoluteMinPauseRange);

		spawnPauseTime = Random.Range(minTime, maxTime);
		return spawnPauseTime;
	}
}
