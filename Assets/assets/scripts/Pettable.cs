using UnityEngine;
using System.Collections;

public class Pettable : MonoBehaviour
{
	public int scoreValue = 1;

	void Start()
	{

	}

	public bool catPet = false;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player") && catPet != true)
		{
			catPet = true;
			transform.localScale = new Vector3(-1, 1, 1);
			FindObjectOfType<ScoreManager>().OnCatPetted(this);
		}

	}
	
}
