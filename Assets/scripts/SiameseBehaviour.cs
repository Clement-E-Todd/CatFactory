using UnityEngine;
using System.Collections;
using System;

public class SiameseBehaviour : CatBehaviour {

	// Use this for initialization
	void Start ()
	{
	
	}

	public override void UpdateMovementPattern()
	{
		transform.position += new Vector3(4f * Time.deltaTime, 0);
	}
}
