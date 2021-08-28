using System.Collections;
using UnityEngine;

[RequireComponent(typeof(FollowerSpawner))]
public abstract class RocketSpawner : WordObjectSpawner
{
    [SerializeField] float m_delayWhileFollow; 

    WaitForSeconds m_timeoutWhileFollow;
    FollowerSpawner m_followerSpawner;

    void Awake()
    {
        m_timeoutWhileFollow = new WaitForSeconds(m_delayWhileFollow);
        m_followerSpawner = GetComponent<FollowerSpawner>();
    }

    protected override IEnumerator SpawnObjectCoroutine()
    {
        GetSpawnPoint();

        OnObjectSpawned();

        yield return m_timeoutWhileFollow;

        Instantiate(m_objectPrefab, m_followerSpawner.CurrentFollower.transform.position, m_objectPrefab.transform.rotation);
        m_followerSpawner.CurrentFollower.SetActive(false);

        yield return m_timeoutAfterSpawn;
        m_isSpawnDelayGoing = false;
    }

    protected abstract void GetSpawnPoint();

    public override void OnObjectSpawned()
    {
        m_followerSpawner.CurrentFollower.SetActive(true);
        m_followerSpawner.CurrentFollower.transform.position = m_objectSpawnPosition + m_spawnOffset;
    }
}
