public class BottomRocketSpawner : RocketSpawner
{
    protected override void GetSpawnPoint()
    {
        m_rocketSpawnPosition = m_playerTransform.position;
        m_rocketSpawnPosition.z = m_playerBorder.position.z;
    }
}
