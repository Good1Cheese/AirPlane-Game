using UnityEngine;

public class EnemyShooting : AirPlaneShooting
{
    [SerializeField] Transform m_firstShootingPoint;
    [SerializeField] Transform m_secondShootingPoint;

    void Update()
    {
        if (m_isDelayGoing) { return; }

        if (m_shootingFromLeft)
        {
            StartCoroutine(ShootCoroutine(m_firstShootingPoint));
            return;
        }
        StartCoroutine(ShootCoroutine(m_secondShootingPoint));
    }
}