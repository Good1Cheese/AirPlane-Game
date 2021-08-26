using UnityEngine;

public class RocketDamable : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamagable damagable))
        {
            damagable.Die();
            gameObject.SetActive(false);
        }
    }
}
