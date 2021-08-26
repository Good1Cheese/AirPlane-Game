using UnityEngine;

public class LeftRocketMove : RocketMove
{
    protected override Vector3 GetMoveDirection()
    {
        return -m_transform.right;
    }
}