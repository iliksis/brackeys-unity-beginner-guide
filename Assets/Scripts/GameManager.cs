using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool gameHasEnded = false;
	float restartDelay = 2f;

	public GameObject completeLevelUi;

	public void EndGame ()
	{
		if (!gameHasEnded)
		{
			Debug.Log("Game Over");
			gameHasEnded = true;
			Invoke("Restart", restartDelay);
		}
	}
	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void CompleteLevel()
	{
		completeLevelUi.SetActive(true);
	}
}
