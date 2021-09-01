using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public enum ScenesId
    {
        StartScene, 
        SettinsScene, 
        PlayScene,
        DeathScene
    }

    public void ChangeScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    public void LoadSceneAsynchronously(int index) => StartCoroutine(LoadSceneAsynchronouslyCoroutine(index));

    public IEnumerator LoadSceneAsynchronouslyCoroutine(int index)
    {
        var loadingSceneProcess = SceneManager.LoadSceneAsync(index);

        while (!loadingSceneProcess.isDone)
        {
            float progress = Mathf.Clamp01(loadingSceneProcess.progress / .9f);
            print(progress);

            yield return null;
        }
    }
}