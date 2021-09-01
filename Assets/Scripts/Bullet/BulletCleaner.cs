using System;
using UnityEngine;

public class BulletCleaner : MonoBehaviour
{
    [SerializeField] float m_rangeOfFlight;
    [SerializeField] float m_bulletRangeMultiplier;

    Predicate<float> m_didBulletReachStopPoint;

    void Start()
    {
        m_rangeOfFlight = transform.position.z + m_rangeOfFlight * m_bulletRangeMultiplier;

        if (m_bulletRangeMultiplier > 0)
        {
            m_didBulletReachStopPoint = delegate (float position) { return position >= m_rangeOfFlight; };
            return;
        }
        m_didBulletReachStopPoint = delegate (float position) { return position <= m_rangeOfFlight; };
    }

    void Update()
    {
        if (m_didBulletReachStopPoint.Invoke(transform.position.z))
        {
            gameObject.SetActive(false);
        }
    }
}
