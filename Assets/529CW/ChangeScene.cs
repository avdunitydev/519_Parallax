using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

	public void LoadGameScene ()
	{
		SceneManager.LoadScene (1);
	}

	public void LoadMainScene ()
	{
		SceneManager.LoadScene (0);
	}

	public void ReloadLevel ()
	{
		SceneManager.LoadScene (Application.loadedLevel);
	}
}
