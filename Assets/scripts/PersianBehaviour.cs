using UnityEngine;
using System.Collections;
using System;

public class PersianBehaviour : CatBehaviour {

	// Use this for initialization
	void Start ()
	{
	
	}

	public override void UpdateMovementPattern()
	{
		transform.position += new Vector3(2.5f * Time.deltaTime, 0);
	}
}
