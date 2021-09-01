using UnityEngine;
using Zenject;

public abstract class PlayerFollower : MonoBehaviour
{
    [SerializeField] Vector3 m_followDirection;

    protected float move;

    public Transform PlayerTransform { get; set; }

    void Update()
    {
        GetFollowDirection();
        transform.Translate(m_followDirection * move);
    }

    public abstract void GetFollowDirection();
}
