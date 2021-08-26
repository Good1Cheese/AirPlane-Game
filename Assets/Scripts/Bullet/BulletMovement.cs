using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] float m_bulletSpeed;
    [SerializeField] float m_directionFlyMultiplier;

    Transform m_transform;

    void Start()
    {
        m_transform = transform;        
    }

    void Update()
    {
        m_transform.Translate((m_transform.forward * m_directionFlyMultiplier) * m_bulletSpeed * Time.deltaTime);    
    }
}
