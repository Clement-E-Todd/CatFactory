using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	const float playerSpeed = 5f;


	void Start ()
	{
	
	}
	

	void Update ()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(-playerSpeed * Time.deltaTime, 0);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3(playerSpeed * Time.deltaTime, 0);
		}


		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3(0, playerSpeed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += new Vector3(0, -playerSpeed * Time.deltaTime);
		}
	}
}
