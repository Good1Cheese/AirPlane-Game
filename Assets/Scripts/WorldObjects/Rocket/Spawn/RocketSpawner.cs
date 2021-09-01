using System;
using System.Collections;
using UnityEngine;

[Serializable]
public abstract class RocketSpawner : WordObjectSpawner
{
    [SerializeField] float m_delayWhileFollow;
    [SerializeField] GameObject m_followEffectPrefab;

    WaitForSeconds m_timeoutWhileFollow;
    GameObject m_currentFollower;

    public float DelayWhileFollow { get => m_delayWhileFollow; set => m_delayWhileFollow = value; }

    new void Start()
    {
        base.Start();
        m_timeoutWhileFollow = new WaitForSeconds(DelayWhileFollow);
    }

    void Awake()
    {
        m_currentFollower = Instantiate(m_followEffectPrefab, Vector3.zero, m_followEffectPrefab.transform.rotation);
        m_currentFollower.GetComponent<PlayerFollower>().PlayerTransform = m_playerTransform;
        m_currentFollower.SetActive(false);
    }

    protected override IEnumerator SpawnObjectCoroutine()
    {
        GetSpawnPoint();

        m_currentFollower.SetActive(true);
        m_currentFollower.transform.position = m_objectSpawnPosition + m_spawnOffset;

        yield return m_timeoutWhileFollow;

        Instantiate(m_objectPrefab, m_currentFollower.transform.position, m_objectPrefab.transform.rotation);
        m_currentFollower.SetActive(false);

        yield return m_timeoutAfterSpawn;
        m_isSpawnDelayGoing = false;
    }

    protected abstract void GetSpawnPoint();
}
