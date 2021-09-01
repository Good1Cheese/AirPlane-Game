using UnityEngine;
using Zenject;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float m_movementSpeed;

    [Inject] readonly CharacterController m_playerCharacterController;
    [Inject] readonly PlayerHealth m_playerHealth;

    Vector3 m_move;

    void Start()
    {
        m_move = new Vector3();
        m_playerHealth.OnPlayerDied += DisableCharacterController;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        m_move.x = horizontal * m_movementSpeed;
        m_move.z = vertical * m_movementSpeed;

        //  m_characterController.velocity += m_move;
        m_playerCharacterController.Move(m_move);
    }

    void DisableCharacterController()
    {
        m_playerCharacterController.enabled = false;
        enabled = false;
    }

    void OnDestroy()
    {
        m_playerHealth.OnPlayerDied -= DisableCharacterController;
    }
}
