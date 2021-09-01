using UnityEngine;
using Zenject;

public class GroundBorderChecker : MonoBehaviour
{
    [SerializeField] GameObject m_playerGameObject;
    [Inject] readonly GroundPositionResetter m_groundMove;

    void OnTriggerEnter(Collider other)
    {
        print(m_playerGameObject);
        if (other.gameObject.Equals(m_playerGameObject))
        {
            m_groundMove.ResetGroundPosition();
        }
    }
}
