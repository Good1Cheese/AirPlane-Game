using System;
using UnityEngine;

public class BulletDamagable : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out IBulletHitable damagable))
        {
            damagable.Damage();
            gameObject.SetActive(false);
        }
    }
}
