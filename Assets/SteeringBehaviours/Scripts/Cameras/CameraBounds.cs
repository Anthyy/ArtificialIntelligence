using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    public Vector3 size = new Vector3(50f, 0f, 20f);

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, size);
    }
   
    /// <summary>
    /// This function returns an adjusted Vector3
    /// </summary>
    /// <param name="incomingPos">The position coming in</param>
    /// <returns></returns>
    public Vector3 GetAdjustedPosition(Vector3 incomingPos)
    {
        // Get bounds position
        Vector3 pos = transform.position;
        Vector3 halfSize = size * 0.5f;

        // If the incomingPos is outside the bounds of X
        if (incomingPos.x > pos.x + halfSize.x)
        {
            // cap it
            incomingPos.x = pos.x + halfSize.x;
        }

        // If the incomingPos is outside the bounds of X
        if (incomingPos.x < pos.x - halfSize.x)
        {
            incomingPos.x = pos.x - halfSize.x;
        }

        // If the incomingPos is outside the bounds of Z
        if (incomingPos.z > pos.z + halfSize.z)
        {
            incomingPos.z = pos.z + halfSize.z;
        }

        // If the incomingPos is outside the bounds of Z
        if (incomingPos.z < pos.z - halfSize.z)
        {
            incomingPos.z = pos.z - halfSize.z;
        }

        return incomingPos;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
