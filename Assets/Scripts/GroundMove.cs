using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField] float m_speed; 

    Transform m_transform;

    void Start()
    {
        m_transform = transform;
    }

    void Update()
    {
        m_transform.Translate(-m_transform.forward * m_speed * Time.deltaTime);
    }

}
