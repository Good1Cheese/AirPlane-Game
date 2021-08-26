using UnityEngine;

public class EnemySpawner : WordObjectSpawner
{
    [SerializeField] Vector3 m_airPlaneSize;

    public override void OnObjectSpawned()
    {
        m_rocketSpawnPosition += m_airPlaneSize;
    }
}
