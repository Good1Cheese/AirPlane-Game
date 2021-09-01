using UnityEngine;
using Zenject;

public class PauseMenuButtonsAction : MonoBehaviour
{
    [Inject] readonly SceneTransition m_sceneTransition;
    [Inject] readonly PauseMenuActivator m_pauseMenuActivator;

    public void Play()
    {
        m_pauseMenuActivator.CursorSetActive(false);
        m_pauseMenuActivator.PauseMenu.SetActive(false);
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
