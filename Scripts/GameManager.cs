using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

	bool gameHasEnded = false;
	public float RestartDelay = 1;
	public GameObject gameFailUI;
	


	public void EndGame()
	{
		
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("Game Over");
			gameFailUI.SetActive(true);
			Invoke("Restart", RestartDelay);// the restart function is dellayed


		}
		//SceneManager.GetActiveScene().name gets the current scene

	}
	void Restart()
	{
		SceneManager.LoadScene("SampleScene");

	}
}
