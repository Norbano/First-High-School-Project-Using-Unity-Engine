using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControlScript : MonoBehaviour
{
	public static MusicControlScript instance;

	private void Awake()
	{
		// allow the music to play while switching scenes
		DontDestroyOnLoad(this.gameObject);

		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}
}
