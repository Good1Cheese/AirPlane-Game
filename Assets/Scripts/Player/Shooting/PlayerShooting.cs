using UnityEngine;
using Zenject;

public class PlayerShooting : AirPlaneShooting
{
    [Inject] readonly PauseMenuActivator m_pauseMenuActivator;

    [SerializeField] Transform m_firstShootingPoint;
    [SerializeField] Transform m_secondShootingPoint;

    void Awake()
    {
        m_pauseMenuActivator.OnPauseMenuActiveStateChanged += SetActiveOrUnActive;
    }

    void SetActiveOrUnActive()
    {
        enabled = !enabled;
    }

    void Update()
    {
        if (!Input.GetMouseButton(0) || m_isDelayGoing) { return; }

        if (m_shootingFromLeft)
        {
            StartCoroutine(ShootCoroutine(m_firstShootingPoint));
            return;
        }
        StartCoroutine(ShootCoroutine(m_secondShootingPoint));
    }

    void OnDestroy()
    {
        m_pauseMenuActivator.OnPauseMenuActiveStateChanged -= SetActiveOrUnActive;
    }
}
