using UnityEngine;
using Zenject;

public class GroundInstaller : MonoInstaller
{
    GroundMove m_groundMove;
    GroundPositionResetter m_groundPositionResetter;
    Transform m_groundTransform;

    public override void InstallBindings()
    {
        GetComponents();
        Container.BindInstance(m_groundPositionResetter).AsSingle();
        Container.BindInstance(m_groundMove).AsSingle();
        Container.BindInstance(m_groundTransform).WithId("GroundTransform").AsCached();
    }

    void GetComponents()
    {
        m_groundTransform = transform;
        m_groundPositionResetter = GetComponent<GroundPositionResetter>();
        m_groundMove = GetComponent<GroundMove>();
    }
}