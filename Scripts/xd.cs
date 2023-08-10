using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xd : MonoBehaviour
{
	public Text HS;

	void Start()
	{
		HS.text = PlayerPrefs.GetFloat("HighScore").ToString("0");
	}
	 public void Reset()
	{
		PlayerPrefs.DeleteAll();
		HS.text = "0";
	}

}
