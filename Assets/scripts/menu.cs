using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {
	public void Menu()
	{
		Application.LoadLevel (0);
	}
	public void RollABall()
	{
		Application.LoadLevel (1);
	}
	public void SpaceZombies()
	{
		Application.LoadLevel (2);
	}
	public void Exit()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}

}
