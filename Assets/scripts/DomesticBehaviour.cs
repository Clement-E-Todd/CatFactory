using UnityEngine;
using System.Collections;
using System;

public class DomesticBehaviour: CatBehaviour {


	public override void UpdateMovementPattern()
	{
		transform.position += new Vector3(10f * Time.deltaTime, 0);
	}

	public override float GetDifficultyRating()
	{
		return 0f;
	}

	public override float GetChanceToSpawn()
	{
		return 1f;
	}
}
