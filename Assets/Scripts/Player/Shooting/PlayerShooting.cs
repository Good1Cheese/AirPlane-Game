using UnityEngine;

public class PlayerShooting : AirPlaneShooting
{
    [SerializeField] Transform m_firstShootingPoint;
    [SerializeField] Transform m_secondShootingPoint;

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
}
