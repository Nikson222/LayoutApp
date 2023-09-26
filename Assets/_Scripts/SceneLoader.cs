using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        if(SceneExists(sceneName))
            SceneManager.LoadScene(sceneName);
    }

    private bool SceneExists(string sceneName)
    {
        string[] sceneNames = GetSceneNamesInBuild();

        foreach (var name in sceneNames)
        {
            if (name == sceneName)
            {
                return true;
            }
        }

        return false;
    }

    private string[] GetSceneNamesInBuild()
    {
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        string[] sceneNames = new string[sceneCount];

        for (int i = 0; i < sceneCount; i++)
        {
            sceneNames[i] = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(i));
        }

        return sceneNames;
    }
}
