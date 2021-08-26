using UnityEngine;

public class RightRocketMove : RocketMove
{
    protected override Vector3 GetMoveDirection()
    {
        return m_transform.right;
    }
}
