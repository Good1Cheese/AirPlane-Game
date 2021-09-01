using UnityEngine;
using Zenject;

public class PlayerRendererDisabler : MonoBehaviour
{
    [Inject] readonly PlayerHealth m_playerHealth;

    MeshRenderer m_playerMeshRenderer;

    void Start()
    {
        m_playerMeshRenderer = GetComponent<MeshRenderer>();
        m_playerHealth.OnPlayerDied += DisableMeshRenderer;
    }

    void DisableMeshRenderer()
    {
        m_playerMeshRenderer.enabled = false;
    }

    void OnDestroy()
    {
        m_playerHealth.OnPlayerDied -= DisableMeshRenderer;
    }
}
