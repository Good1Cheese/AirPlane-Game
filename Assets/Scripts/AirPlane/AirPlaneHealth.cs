using UnityEngine;

public class AirPlaneHealth : MonoBehaviour, IBulletHitable, IRocketHitable
{
    [SerializeField] protected int m_maxHeathAmout;
    [SerializeField] protected GameObject m_destroyEffect;

    public int HealthAmout { get; set; }

    void Awake()
    {
        HealthAmout = m_maxHeathAmout;
    }

    public void Damage()
    {
        HealthAmout--;

        if (HealthAmout <= 0) { Die(); }
    }

    public virtual void Die()
    {
        Instantiate(m_destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void Hit()
    {
        Die();
    }
}
