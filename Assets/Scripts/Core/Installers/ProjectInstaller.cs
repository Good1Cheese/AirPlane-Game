using UnityEngine;
using Zenject;

[RequireComponent(typeof(SceneTransition))]
public class ProjectInstaller : MonoInstaller
{
    SceneTransition m_sceneTransition;

    public override void InstallBindings()
    {
        GetComponents();
        Container.BindInstance(m_sceneTransition).AsSingle();
    }

    void GetComponents()
    {
        m_sceneTransition = GetComponent<SceneTransition>();
    }
}