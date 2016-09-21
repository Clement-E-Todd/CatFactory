using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	public int score = 0;

	public void OnCatPetted(Pettable pettable)
	{
		score += pettable.scoreValue;
		Debug.Log(score);
	}

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
