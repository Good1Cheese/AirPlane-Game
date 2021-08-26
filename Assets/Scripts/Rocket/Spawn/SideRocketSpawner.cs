public class SideRocketSpawner : RocketSpawner
{
    protected override void GetSpawnPoint()
    {
        m_rocketSpawnPosition = m_playerTransform.position;
        m_rocketSpawnPosition.x = m_playerBorder.position.x;
    }
}
