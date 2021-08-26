public class PlayerFollowerByZ : PlayerFollower
{
    public override void GetFollowDirection()
    {
        move = PlayerTransform.position.z - m_transform.position.z;
    }
}
