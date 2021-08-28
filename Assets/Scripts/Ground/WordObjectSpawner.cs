using System.Collections;
using UnityEngine;
using Zenject;

public abstract class WordObjectSpawner : MonoBehaviour
{
    [SerializeField] protected GameObject m_objectPrefab;
    [SerializeField] protected Vector3 m_spawnOffset;
    [SerializeField] protected Transform m_playerBorder;

    [SerializeField] protected int m_minTimeForSpawn;
    [SerializeField] protected int m_maxTimeForSpawn;

    [SerializeField] protected float m_delayAfterSpawn;

    [Inject] protected readonly Transform m_playerTransform;

    protected bool m_isSpawnDelayGoing;
    protected WaitForSeconds m_timeoutAfterSpawn;
    protected Vector3 m_objectSpawnPosition = new Vector3();

    void Start()
    {
        m_timeoutAfterSpawn = new WaitForSeconds(m_delayAfterSpawn);
    }

    void Update()
    {
        if (!m_isSpawnDelayGoing)
        {
            m_isSpawnDelayGoing = true;
            Invoke(nameof(SpawnObject), Random.Range(m_minTimeForSpawn, m_maxTimeForSpawn));
        }
    }

    void SpawnObject() => StartCoroutine(SpawnObjectCoroutine());

    protected virtual IEnumerator SpawnObjectCoroutine()
    {
        m_objectSpawnPosition = m_playerTransform.position;
        m_objectSpawnPosition.z = m_playerBorder.position.z;
        m_objectSpawnPosition += m_spawnOffset;

        OnObjectSpawned();
        Instantiate(m_objectPrefab, m_objectSpawnPosition, m_objectPrefab.transform.rotation);

        yield return m_timeoutAfterSpawn;
        m_isSpawnDelayGoing = false;
    }

    public abstract void OnObjectSpawned();
}