using UnityEngine;
using UnityEditor;

public class Small_Path : MonoBehaviour
{
    // Use Waypoints GameObject prefab
    public GameObject[] Small_Waypoints; // Path for small fish

    // Move fish to waypoints
    public Vector3 GetPosition(int index)
    {
        return Small_Waypoints[index].transform.position;

    }

    // Draw Gizmos to see GameObject paths and labels
    private void OnDrawGizmos()
    {
        // Draw small fish waypoint labels
        if (Small_Waypoints.Length > 0)
        {
            for (int i = 0; i < Small_Waypoints.Length; i++)
            {
                // Create labels and attach to correct GameObject
                GUIStyle style = new GUIStyle();
                style.normal.textColor = Color.white;
                style.alignment = TextAnchor.MiddleCenter;
                Handles.Label(Small_Waypoints[i].transform.position + Vector3.up * 0.7f, Small_Waypoints[i].name, style);

                // Draw lines to represent path script between GameObjects
                if (i < Small_Waypoints.Length - 1)
                {
                    Gizmos.color = Color.gray;
                    Gizmos.DrawLine(Small_Waypoints[i].transform.position, Small_Waypoints[i + 1].transform.position);   
                }
            }
        }
    }
}