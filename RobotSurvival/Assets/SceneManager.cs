using UnityEngine;

public class SceneManager : MonoBehaviour {

	public void ChangeScenes(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
