using UnityEngine;
using System.Collections;
using System;

public class SiameseBehaviour : CatBehaviour {

	public override void UpdateMovementPattern()
	{
		transform.position += new Vector3(4f * Time.deltaTime, 0);
	}

	public override float GetDifficultyRating()
	{
		return 1f;
	}

	public override float GetChanceToSpawn()
	{
		return 0.1f;
	}
}
