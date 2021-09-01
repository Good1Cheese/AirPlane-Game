using UnityEngine;
using Zenject;

public class MouseDeactivator : MonoBehaviour
{
    [Inject] readonly PauseMenuActivator m_pauseMenuActivator;
    [Inject] readonly PlayerHealth m_playerHealth;

    void Start()
    {
        m_playerHealth.OnPlayerDied += TurnOnCursor;
    }

    public void TurnOnCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void OnDestroy()
    {
        m_playerHealth.OnPlayerDied -= TurnOnCursor;
    }
}