using UnityEngine;

public class AngleEffect : MonoBehaviour
{
    [SerializeField] float m_tiltAngle;
    [SerializeField] float m_smooth;

    Transform m_transform;

    void Start()
    {
        m_transform = transform;    
    }

    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * m_tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * m_tiltAngle;

        Quaternion target = Quaternion.Euler(tiltAroundX, 0, -tiltAroundZ);

        m_transform.rotation = Quaternion.Slerp(m_transform.rotation, target, Time.deltaTime * m_smooth);
    }

}