public class PlayerFollowerByZ : PlayerFollower
{
    public override void GetFollowDirection()
    {
        move = PlayerTransform.position.z - transform.position.z;
    }
}
