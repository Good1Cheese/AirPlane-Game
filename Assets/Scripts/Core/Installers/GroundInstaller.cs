using UnityEngine;
using Zenject;

public class GroundInstaller : MonoInstaller
{
    GroundResetter m_groundMove;

    public override void InstallBindings()
    {
        GetComponents();
        Container.BindInstance(m_groundMove).AsSingle();
    }

    void GetComponents()
    {
        m_groundMove = GetComponent<GroundResetter>();
    }
}