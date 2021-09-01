using UnityEngine;

public class ModifierSelecter : MonoBehaviour
{
    IGameModifier[] m_modifiers;

    void Start()
    {
        m_modifiers = GetComponents<IGameModifier>();
        m_modifiers[Random.Range(0, m_modifiers.Length)].ApplyModifier();
    }
}
