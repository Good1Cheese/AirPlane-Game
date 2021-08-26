public class PlayerFollowerByX : PlayerFollower
{

    public override void GetFollowDirection()
    {
        move = PlayerTransform.position.x - m_transform.position.x;
    }
}
