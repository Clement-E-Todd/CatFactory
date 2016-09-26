using UnityEngine;
using System.Collections;
using System;

public class PersianBehaviour : CatBehaviour {

	public override void UpdateMovementPattern()
	{
		transform.position += new Vector3(2.5f * Time.deltaTime, 0);
	}

	public override float GetDifficultyRating()
	{
		return 0.75f;
		
	}

	public override float GetChanceToSpawn()
	{
		return 0.25f;
	}
}
