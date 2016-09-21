using UnityEngine;
using System.Collections;

public class CatSpawner : MonoBehaviour {

	const float spawnDistanceX = -9f;
	const float minSpawnDistanceY = -4f;
	const float maxSpawnDistanceY = 4f;

	void Start ()
	{
		InvokeRepeating("SpawnCat", 2, 3);
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
	}
}
