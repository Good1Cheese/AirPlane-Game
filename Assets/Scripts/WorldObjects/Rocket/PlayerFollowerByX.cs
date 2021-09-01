public class PlayerFollowerByX : PlayerFollower
{
    public override void GetFollowDirection()
    {
        move = PlayerTransform.position.x - transform.position.x;
    }
}
