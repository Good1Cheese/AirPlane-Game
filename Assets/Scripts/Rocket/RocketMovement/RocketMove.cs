using System;
using UnityEngine;

public abstract class RocketMove : MonoBehaviour
{
    [SerializeField] float m_bulletSpeed;

    protected Transform m_transform;

    void Start()
    {
        m_transform = transform;
    }

    void Update()
    {
        m_transform.Translate(GetMoveDirection() * m_bulletSpeed * Time.deltaTime);
    }

    protected abstract Vector3 GetMoveDirection();
}
