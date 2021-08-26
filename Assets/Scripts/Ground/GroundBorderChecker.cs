using UnityEngine;
using Zenject;

public class GroundBorderChecker : MonoBehaviour
{
    [SerializeField] GameObject m_playerGameObject;
    [Inject] readonly GroundResetter m_groundMove;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(m_playerGameObject))
        {
            m_groundMove.ResetGroundPosition();
        }
    }
}
