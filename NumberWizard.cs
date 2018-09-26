using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
	

	// Use this for initialization

	int min;
	int max;
	int guess;

	void Start ()
	{
		min = 1;
		max = 1000;
		guess = Random.Range (min, max);
		Debug.Log ("min: " + min + "max:" + max);
		StartGame ();
	}

	void StartGame ()
	{
		Debug.Log ("think of a number between 1 and 1000 my guess is" + guess);
	
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.DownArrow)) {

			max = guess;
			calcGuess ();

		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			
			min = guess;
			calcGuess ();
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			max = 0; 
			Debug.Log ("Guessed right");
		}
	}

	void calcGuess ()
	{
		
		guess = (min + max) / 2;
		Debug.Log ("Is the number equal to, higher or lower than " + guess + "?");
	
	}
}

