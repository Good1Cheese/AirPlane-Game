using UnityEngine;
using Zenject;

public class MainMenuButtonsAction : MonoBehaviour
{
    [Inject] SceneTransition m_sceneTransition;

    public void Play()
    {
        m_sceneTransition.ChangeScene((int)SceneTransition.ScenesId.PlayScene);
    }

    public void EnterSettings()
    {
        m_sceneTransition.ChangeScene((int)SceneTransition.ScenesId.SettinsScene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
