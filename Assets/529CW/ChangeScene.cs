using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void LoadGameScene()
	{
        SceneManager.LoadScene(1);
	}
    public void LoadMainScene()
    {
        SceneManager.LoadScene(0);
    }
    public void ScaleUpItem(){
        transform.localScale = new Vector3(1.2f, 1.2f, transform.localScale.z);
    }
    public void ScaleNormalItem(){
        transform.localScale = new Vector3(1, 1, transform.localScale.z);
    }

}
