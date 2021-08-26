using UnityEngine;

public abstract class PlayerFollower : MonoBehaviour
{
    [SerializeField] Vector3 m_followDirection;

    protected Transform m_transform;
    protected float move;

    public Transform PlayerTransform { get; set; }

    void Start()
    {
        m_transform = transform;
    }

    void Update()
    {
        GetFollowDirection();
        m_transform.Translate(m_followDirection * move);
    }

    public abstract void GetFollowDirection();
}
