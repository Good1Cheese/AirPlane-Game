using UnityEngine;
using Zenject;

public class FollowerSpawner : MonoBehaviour
{
    [SerializeField] GameObject m_followEffectPrefab;
    [Inject] readonly Transform m_playerTransform;

    public GameObject CurrentFollower { get; private set; }

    void Awake()
    {
        CurrentFollower = Instantiate(m_followEffectPrefab, Vector3.zero, m_followEffectPrefab.transform.rotation);
        CurrentFollower.GetComponent<PlayerFollower>().PlayerTransform = m_playerTransform;
        CurrentFollower.SetActive(false);
    }
}