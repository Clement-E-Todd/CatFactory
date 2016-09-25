using UnityEngine;
using System.Collections;
using System;

public class DomesticBehaviour: CatBehaviour {

	// Use this for initialization
	void Start ()
	{
	
	}

	public override void UpdateMovementPattern()
	{
		transform.position += new Vector3(10f * Time.deltaTime, 0);
	}
}
