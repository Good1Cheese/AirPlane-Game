using UnityEngine;

public class ForwardRocketMove : RocketMove
{
    protected override Vector3 GetMoveDirection()
    {
        return m_transform.forward;
    }
}
