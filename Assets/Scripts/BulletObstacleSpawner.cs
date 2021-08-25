using System.Collections;
using UnityEngine;
using Zenject;

public class BulletObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject m_obstaclePrefab;
    [SerializeField] Transform m_topPlayerBorder;

    [SerializeField] int m_minTimeForSpawn;
    [SerializeField] int m_maxTimeForSpawn;

    [SerializeField] float m_delayAfterSpawn;

    [Inject] readonly Transform m_playerTransform;

    bool m_isSpawnDelayGoing;
    WaitForSeconds m_timeoutAfterSpawn;
    Vector3 m_bulletSpawnPosition = new Vector3();

    void Start()
    {
        m_timeoutAfterSpawn = new WaitForSeconds(m_delayAfterSpawn);
    }

    void Update()
    {
        if (!m_isSpawnDelayGoing)
        {
            m_isSpawnDelayGoing = true;
            Invoke(nameof(SpawnBullet), Random.Range(m_minTimeForSpawn, m_maxTimeForSpawn));
        }
    }

    void SpawnBullet() => StartCoroutine(SpawnBulletCoroutine());

    IEnumerator SpawnBulletCoroutine()
    {
        m_bulletSpawnPosition = m_playerTransform.position;
        m_bulletSpawnPosition.z = m_topPlayerBorder.position.z;

        Instantiate(m_obstaclePrefab, m_bulletSpawnPosition, m_obstaclePrefab.transform.rotation);

        yield return m_timeoutAfterSpawn;
        m_isSpawnDelayGoing = false;
    }
}
