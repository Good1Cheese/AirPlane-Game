using System;
using System.Collections;
using UnityEngine;
using Zenject;

public class PlayerHealth : AirPlaneHealth
{
    [Inject] readonly SceneTransition m_sceneTransition;

    public Action OnPlayerDied { get; set; }

    public override void Die()
    {
        StartCoroutine(DieCoroutine());
    }

    public IEnumerator DieCoroutine()
    {
        OnPlayerDied.Invoke();
        Instantiate(m_destroyEffect, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(2.5f);

        m_sceneTransition.ChangeScene((int)SceneTransition.ScenesId.DeathScene);
    }

}