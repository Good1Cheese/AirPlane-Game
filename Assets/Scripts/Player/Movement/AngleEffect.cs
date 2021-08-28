using UnityEngine;

public class AngleEffect : MonoBehaviour
{
    [SerializeField] float m_tiltAngle;
    [SerializeField] float m_smooth;

    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * m_tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * m_tiltAngle;

        Quaternion target = Quaternion.Euler(tiltAroundX, 0, -tiltAroundZ);

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * m_smooth);
    }

}