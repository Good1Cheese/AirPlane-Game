using UnityEngine;

public class AirPlaneHealth : MonoBehaviour, IDamagable
{
    [SerializeField] float m_maxHeathAmout;

    float m_healthAmout;

    void Start()
    {
        m_healthAmout = m_maxHeathAmout;    
    }

    public void Damage(float m_damageAmout)
    {
        m_healthAmout -= m_damageAmout;

        if (m_healthAmout <= 0) { Destroy(gameObject); }
    }

}