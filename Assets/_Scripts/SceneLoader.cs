using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string SceneName)
    {
        Scene sceneForLoad = SceneManager.GetSceneByName(SceneName);
        if(sceneForLoad.IsValid())
            SceneManager.LoadScene(SceneName);
    }
}
