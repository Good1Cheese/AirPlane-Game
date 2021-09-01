using System.Collections;
using UnityEngine;

public class AirPlaneShooting : MonoBehaviour
{
    [SerializeField] protected GameObject m_bulletPrefab;
    [SerializeField] protected float m_delayAfterShot;

    protected WaitForSeconds m_timeoutAfterShot;
    protected bool m_shootingFromLeft = true;
    protected bool m_isDelayGoing;

    void Start()
    {
        print(m_delayAfterShot);
        m_timeoutAfterShot = new WaitForSeconds(m_delayAfterShot);
    }

    protected IEnumerator ShootCoroutine(Transform spawnPoint)
    {
        m_isDelayGoing = true;

        Instantiate(m_bulletPrefab,
                    spawnPoint.position,
                    m_bulletPrefab.transform.rotation);

        yield return m_timeoutAfterShot;

        m_shootingFromLeft = !m_shootingFromLeft;
        m_isDelayGoing = false;
    }
}
