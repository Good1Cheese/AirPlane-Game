using System;
using UnityEngine;

public class PauseMenuActivator : MonoBehaviour
{
    [SerializeField] GameObject m_pauseMenu;

    public GameObject PauseMenu { get => m_pauseMenu; }
    public Action OnPauseMenuActiveStateChanged { get; set; }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        PauseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("PauseMenu"))
        {
            OnPauseMenuActiveStateChanged.Invoke();
            PauseMenu.SetActive(!PauseMenu.activeSelf);

            CursorSetActive(PauseMenu.activeSelf);
        }
    }

    public void CursorSetActive(bool active)
    {
        Cursor.visible = active;
        if (active)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            return;
        }
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }


}
