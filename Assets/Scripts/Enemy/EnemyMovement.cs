using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float m_frequency;
    [SerializeField] float m_amplitute;

    void Update()
    {
        transform.Translate(Mathf.Sin(Time.time * m_frequency) * Time.deltaTime * m_amplitute, 0, 0);
    }
}
