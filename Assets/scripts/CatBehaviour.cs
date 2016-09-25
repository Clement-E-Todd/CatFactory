using UnityEngine;
using System.Collections;

 public abstract class CatBehaviour : MonoBehaviour {

	const float postPetSpeed = 2.5f;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GetComponent<Pettable>().catPet)
		{
			transform.position -= new Vector3(postPetSpeed * Time.deltaTime, 0);
		}

		else
		{
			UpdateMovementPattern();
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

	public abstract void UpdateMovementPattern();

}
