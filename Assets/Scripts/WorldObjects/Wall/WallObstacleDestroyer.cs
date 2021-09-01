using UnityEngine;

public class WallObstacleDestroyer : MonoBehaviour, IRocketHitable, IBulletHitable
{
    [SerializeField] GameObject m_destroyEffect;

    public void Damage()
    {
        
    }

    public void Hit()
    {
        Instantiate(m_destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
    