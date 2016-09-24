using UnityEngine;
using System.Collections;

public class GrumpyManager : MonoBehaviour {

	public float grumpiness = 0f;

	public const float grumpinessGained = 0.1f;

	void Start ()
	{
	
	}

	void Update ()
	{
	
	}

	public void OnCatWasMissed()
	{
		grumpiness = Mathf.Min(grumpiness + grumpinessGained, 1f);
		Debug.Log(grumpiness);

		if (grumpiness >= 1)
		{
			Debug.Log("YOU LOSE, CHUMP.");
		}
	}
}

