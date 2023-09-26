using UnityEngine;

public class SceneChangerButton : ActionButton
{
    [SerializeField] private string _sceneName = "";
    [SerializeField] private SceneLoader _sceneLoader;

    void Start()
    {
        AddListenerOnClick(() => _sceneLoader.LoadScene(_sceneName));
    }
}
