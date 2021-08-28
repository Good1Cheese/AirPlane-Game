using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField] float m_speed; 

    void Update()
    {
        transform.Translate(-transform.forward * m_speed * Time.deltaTime);
    }

}
