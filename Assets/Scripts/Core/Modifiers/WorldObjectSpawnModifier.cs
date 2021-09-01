using UnityEngine;

public class WorldObjectSpawnModifier : MonoBehaviour, IGameModifier
{
    [SerializeField] WordObjectSpawner m_wordObjectSpawner;
    [SerializeField] ObjectSpawnTime m_worldObjectSpawnTime;

    public void ApplyModifier()
    {
        m_wordObjectSpawner.SetObjectSpawnTime(m_worldObjectSpawnTime);
    }
}