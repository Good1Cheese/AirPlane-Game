using UnityEngine;

public class GroundPositionResetter : MonoBehaviour
{
    [SerializeField] Transform m_lastGroundChunk;
    [SerializeField] Transform m_firstGroundChunk;

    Vector3 m_groundSpawnOffset = new Vector3(0, 0, 118.7f);

    public void ResetGroundPosition()
    {
        m_firstGroundChunk.position = m_lastGroundChunk.position + m_groundSpawnOffset;

        Transform m_oldLastGroundChunk = m_lastGroundChunk;
        m_lastGroundChunk = m_firstGroundChunk;
        m_firstGroundChunk = m_oldLastGroundChunk;
    }
}
