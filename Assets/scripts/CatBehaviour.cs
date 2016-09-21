using UnityEngine;
using System.Collections;

public class CatBehaviour : MonoBehaviour {

	const float catSpeed = 2.5f;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += new Vector3(catSpeed * Time.deltaTime, 0);
	}
}
