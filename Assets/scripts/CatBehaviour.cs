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
		if (GetComponent<Pettable>().catPet)
		{
			transform.position -= new Vector3(catSpeed * Time.deltaTime, 0);
		}

		else
		{
			transform.position += new Vector3(catSpeed * Time.deltaTime, 0);
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("GameController"))
		{
			Destroy(gameObject);

			if (GetComponent<Pettable>().catPet == false)
			{
				FindObjectOfType<GrumpyManager>().OnCatWasMissed();
			}
		}
	}
}
