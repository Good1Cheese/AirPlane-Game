using UnityEngine;

public class RocketDamable : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out IRocketHitable rocketHitable))
        {
            rocketHitable.Hit();
            gameObject.SetActive(false);
        }
    }
}
