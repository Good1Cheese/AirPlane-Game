public class SideRocketSpawner : RocketSpawner
{
    protected override void GetSpawnPoint()
    {
        m_objectSpawnPosition = m_playerTransform.position;
        m_objectSpawnPosition.x = m_playerBorder.position.x;
    }
}
