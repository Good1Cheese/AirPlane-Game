using UnityEngine;
using Zenject;

public class DeathSceneUI : MonoBehaviour
{
    [Inject] readonly SceneTransition m_sceneTransition;

    public void Restart()
    {
        m_sceneTransition.ChangeScene((int)SceneTransition.ScenesId.PlayScene);
    }
}
