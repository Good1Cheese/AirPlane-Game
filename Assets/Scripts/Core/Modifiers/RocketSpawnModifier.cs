using UnityEngine;

public class RocketSpawnModifier : MonoBehaviour, IGameModifier
{
    [SerializeField] RocketSpawner m_rocketSpawner;
    [SerializeField] ObjectSpawnTime m_worldObjectSpawnTime;
    [SerializeField] float m_delayWhileFollow;

    public void ApplyModifier()
    {
        m_rocketSpawner.SetObjectSpawnTime(m_worldObjectSpawnTime);
        m_rocketSpawner.DelayWhileFollow = m_delayWhileFollow;
    }
}
