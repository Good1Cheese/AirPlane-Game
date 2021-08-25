using UnityEngine;

public class AirPlaneFlyEffect : MonoBehaviour
{
    [SerializeField] float m_frequency;
    [SerializeField] float m_amplitute;

    Transform m_transform;

    void Start()
    {
        m_transform = transform;
    }

    void Update()
    {
        m_transform.Translate(0, Mathf.Sin(Time.time * m_frequency) * Time.deltaTime * m_amplitute, 0);
    }

}
