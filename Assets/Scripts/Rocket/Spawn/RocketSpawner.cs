using System.Collections;
using UnityEngine;

public abstract class RocketSpawner : WordObjectSpawner
{
    [SerializeField] float m_delayWhileFollow; 
    [SerializeField] GameObject m_followEffectPrefab;
    [SerializeField] Vector3 m_spawnOffset;

    WaitForSeconds m_timeoutWhileFollow;

    GameObject m_currentFollower;

    void Awake()
    {
        m_timeoutWhileFollow = new WaitForSeconds(m_delayWhileFollow);
        m_currentFollower = Instantiate(m_followEffectPrefab, Vector3.zero, m_followEffectPrefab.transform.rotation);
        m_currentFollower.GetComponent<PlayerFollower>().PlayerTransform = m_playerTransform;
        m_currentFollower.SetActive(false);
    }

    protected override IEnumerator SpawnObjectCoroutine()
    {
        GetSpawnPoint();

        OnObjectSpawned();

        yield return m_timeoutWhileFollow;

        Instantiate(m_objectPrefab, m_currentFollower.transform.position, m_objectPrefab.transform.rotation);
        m_currentFollower.SetActive(false);

        yield return m_timeoutAfterSpawn;
        m_isSpawnDelayGoing = false;
    }

    protected abstract void GetSpawnPoint();

    public override void OnObjectSpawned()
    {
        m_currentFollower.SetActive(true);
        m_currentFollower.transform.position = m_rocketSpawnPosition + m_spawnOffset;
    }
}
