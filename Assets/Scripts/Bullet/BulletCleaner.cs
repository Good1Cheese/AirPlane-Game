using System;
using UnityEngine;

public class BulletCleaner : MonoBehaviour
{
    [SerializeField] float m_rangeOfFlight;
    [SerializeField] float m_bulletRangeMultiplier;

    Func<bool> m_didBulletReachStopPoint;

    void Start()
    {
        m_rangeOfFlight = transform.position.z + m_rangeOfFlight * m_bulletRangeMultiplier;

        if (m_bulletRangeMultiplier > 0)
        {
            m_didBulletReachStopPoint = delegate () { return transform.position.z >= m_rangeOfFlight; };
            return;
        }
        m_didBulletReachStopPoint = delegate () { return transform.position.z <= m_rangeOfFlight; };
    }

    void Update()
    {
        if (m_didBulletReachStopPoint.Invoke())
        {
            gameObject.SetActive(false);
        }
    }
}
