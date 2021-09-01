using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    PlayerHealth m_playerHealth;
    GameObject m_playerGameObject;
    Transform m_playerTransform;
    CharacterController m_playerCharacterController;
    PauseMenuActivator m_pauseMenuActivator;

    public override void InstallBindings()
    {
        GetComponents();
        Container.BindInstance(m_playerGameObject).AsSingle();
        Container.BindInstance(m_playerCharacterController).AsSingle();
        Container.BindInstance(m_playerHealth).AsSingle();
        Container.BindInstance(m_pauseMenuActivator).AsSingle();
        Container.BindInstance(m_playerTransform).WithId("PlayerTransform").AsCached();
    }

    void GetComponents()
    {
        m_playerGameObject = gameObject;
        m_playerTransform = transform;
        m_playerHealth = GetComponent<PlayerHealth>();
        m_playerCharacterController = GetComponent<CharacterController>();
        m_pauseMenuActivator = GetComponent<PauseMenuActivator>();
    }
}