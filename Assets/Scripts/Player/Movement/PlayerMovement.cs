using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float m_movementSpeed;

    CharacterController m_characterController;

    Vector3 m_move;

    void Start()
    {
        m_characterController = GetComponent<CharacterController>();
        m_move = new Vector3();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;    
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        m_move.x = horizontal * m_movementSpeed;
        m_move.z = vertical * m_movementSpeed;

        m_characterController.Move(m_move);
    }
}
