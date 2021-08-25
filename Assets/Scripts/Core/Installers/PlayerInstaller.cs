using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    GameObject m_playerGameObject;
    Transform m_playerTransform;

    public override void InstallBindings()
    {
        GetComponents();
        Container.BindInstance(m_playerGameObject).AsSingle();
        Container.BindInstance(m_playerTransform).AsSingle();
    }

    void GetComponents()
    {
        m_playerGameObject = gameObject;
        m_playerTransform = transform;
    }
}