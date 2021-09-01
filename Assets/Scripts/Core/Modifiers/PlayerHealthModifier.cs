using UnityEngine;
using Zenject;

public class PlayerHealthModifier : MonoBehaviour, IGameModifier
{
    [Inject] readonly PlayerHealth m_playerHealth;

    public void ApplyModifier()
    {
        m_playerHealth.HealthAmout = 1;
    }
}
