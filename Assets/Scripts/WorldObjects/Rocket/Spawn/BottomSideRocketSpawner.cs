public class BottomSideRocketSpawner : RocketSpawner
{
    protected override void GetSpawnPoint()
    {
        m_objectSpawnPosition = m_playerTransform.position;
        m_objectSpawnPosition.z = m_playerBorder.position.z;
    }
}
