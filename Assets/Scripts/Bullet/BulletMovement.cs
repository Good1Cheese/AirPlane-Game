using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] float m_speed;

    void Update()
    {
        transform.Translate(Vector3.forward * m_speed * Time.deltaTime);                                                       
    }
}
