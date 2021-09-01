using System.Collections;
using UnityEngine;
using Zenject;

public class WordObjectSpawner : MonoBehaviour
{
    [SerializeField] protected GameObject m_objectPrefab;
    [SerializeField] protected Vector3 m_spawnOffset;
    [SerializeField] protected Transform m_playerBorder;

    [SerializeField] ObjectSpawnTime m_worldObjectSpawnTime;

    [Inject(Id = "PlayerTransform")]
    protected readonly Transform m_playerTransform;

    protected bool m_isSpawnDelayGoing;
    protected WaitForSeconds m_timeoutAfterSpawn;
    protected Vector3 m_objectSpawnPosition = new Vector3();

    protected void Start()
    {
        m_timeoutAfterSpawn = new WaitForSeconds(m_worldObjectSpawnTime.delayAfterSpawn);
    }

    void Update()
    {
        if (!m_isSpawnDelayGoing)
        {
            m_isSpawnDelayGoing = true;
            Invoke(nameof(SpawnObject), UnityEngine.Random.Range(m_worldObjectSpawnTime.minTimeForSpawn, m_worldObjectSpawnTime.maxTimeForSpawn));
        }
    }

    void SpawnObject()
    {
        StartCoroutine(SpawnObjectCoroutine());
    }

    protected virtual IEnumerator SpawnObjectCoroutine()
    {
        m_objectSpawnPosition = m_playerTransform.position;
        m_objectSpawnPosition.z = m_playerBorder.position.z;
        m_objectSpawnPosition += m_spawnOffset;

        Instantiate(m_objectPrefab, m_objectSpawnPosition, m_objectPrefab.transform.rotation);

        yield return m_timeoutAfterSpawn;
        m_isSpawnDelayGoing = false;
    }

    public void SetObjectSpawnTime(ObjectSpawnTime newWorldObjectSpawnTime)
    {
        m_worldObjectSpawnTime = newWorldObjectSpawnTime;
        Start();
    }

}
