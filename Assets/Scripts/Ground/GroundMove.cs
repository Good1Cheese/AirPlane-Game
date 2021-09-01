using System;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField] float m_speed;

    public Func<float> GetDeltaTime { get; set; } = () => Time.deltaTime;   

    void Update()
    {
        transform.Translate(-transform.forward * m_speed * GetDeltaTime());
    }
}
    