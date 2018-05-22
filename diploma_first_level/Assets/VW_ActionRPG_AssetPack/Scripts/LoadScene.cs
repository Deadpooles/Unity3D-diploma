using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;
using System;

public class LoadScene : MonoBehaviour {

	public int level;

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Loading Level");
		Application.LoadLevel(level);
	}
}
