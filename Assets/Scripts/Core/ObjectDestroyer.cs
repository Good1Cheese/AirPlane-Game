using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField] float m_destroyDelay;

    void Start()
    {
        Destroy(gameObject, m_destroyDelay);    
    }
}
