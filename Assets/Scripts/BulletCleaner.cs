using System;
using UnityEngine;

public class BulletCleaner : MonoBehaviour
{
    [SerializeField] float m_rangeOfFlight;
    [SerializeField] float m_bulletRangeMultiplier;

    Transform m_transform;
    Func<bool> m_didBulletReachStopPoint;

    void Start()
    {
        m_transform = transform;
        m_rangeOfFlight = m_transform.position.z + m_rangeOfFlight * m_bulletRangeMultiplier;

        if (m_bulletRangeMultiplier > 0)
        {
            m_didBulletReachStopPoint = delegate () { return m_transform.position.z >= m_rangeOfFlight; };
            return;
        }
        m_didBulletReachStopPoint = delegate () { return m_transform.position.z <= m_rangeOfFlight; };
    }

    void Update()
    {
        if (m_didBulletReachStopPoint.Invoke())
        {
            gameObject.SetActive(false);
        }
    }
}
