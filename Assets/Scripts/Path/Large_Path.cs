using UnityEngine;
using UnityEditor;

public class Large_Path : MonoBehaviour
{
    // Use Waypoints GameObject prefab
    public GameObject[] Large_Waypoints;    // Path for large fish

    // Move fish to waypoints
    public Vector3 GetPosition(int index)
    {
        return Large_Waypoints[index].transform.position;

    }

    // Draw Gizmos to see GameObject paths and labels
    private void OnDrawGizmos()
    {
        // Draw large fish waypoint labels
        if (Large_Waypoints.Length > 0)
        {
            for (int i = 0; i < Large_Waypoints.Length; i++)
            {
                // Create labels and attach to correct GameObject
                GUIStyle style = new GUIStyle();
                style.normal.textColor = Color.white;
                style.alignment = TextAnchor.MiddleCenter;
                Handles.Label(Large_Waypoints[i].transform.position + Vector3.up * 0.7f, Large_Waypoints[i].name, style);

                // Draw lines to represent path script between GameObjects
                if (i < Large_Waypoints.Length - 1)
                {
                    Gizmos.color = Color.gray;
                    Gizmos.DrawLine(Large_Waypoints[i].transform.position, Large_Waypoints[i + 1].transform.position);   
                }
            }
        }
    }
}
