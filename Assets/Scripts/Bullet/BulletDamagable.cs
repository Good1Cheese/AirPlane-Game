using System;
using UnityEngine;

public class BulletDamagable : MonoBehaviour
{
    [SerializeField] float m_damageAmout;

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamagable damagable))
        {
            damagable.Damage(m_damageAmout);
            gameObject.SetActive(false);
        }
    }
}
