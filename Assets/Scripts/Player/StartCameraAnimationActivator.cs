using System.Collections;
using UnityEngine;
using Zenject;

public class StartCameraAnimationActivator : MonoBehaviour
{
    [Inject] readonly GameObject m_playerGameObject;
    
    Animator m_animator;

    IEnumerator Start()
    {
        print("ds");
        m_animator = GetComponent<Animator>();
        m_animator.SetTrigger("OnGameStarted");
        Time.timeScale = 0;

        m_playerGameObject.SetActive(false);
        yield return GetStartAnimationLenght();
        m_playerGameObject.SetActive(true);
        Time.timeScale = 1;
    }

    float GetStartAnimationLenght()
    {
        return m_animator.runtimeAnimatorController.animationClips[0].length;
    }
}
