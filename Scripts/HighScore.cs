
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public Transform player;
    public Text highScore;
    float number;
    void Start()
    {
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
    }

	 void Update()
	{
        number = player.position.z;
        if (number > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", number);
            highScore.text = number.ToString("0");
        }
    }

	public void Reset()
    {
        PlayerPrefs.DeleteAll();
        highScore.text = "0";
    }
}
