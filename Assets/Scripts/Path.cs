/* using UnityEngine;
using UnityEditor;

public class Path : MonoBehaviour
{
    // Use Waypoints GameObject prefab
    public GameObject[] Small_Waypoints; // Path for small fish
    public GameObject[] Med_Waypoints;  // Path for medium fish
    public GameObject[] Large_Waypoints;    // Path for large fish

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

        // Draw med fish waypoint labels
        if (Med_Waypoints.Length > 0)
        {
            for (int i = 0; i < Med_Waypoints.Length; i++)
            {
                // Create labels and attach to correct GameObject
                GUIStyle style = new GUIStyle();
                style.normal.textColor = Color.white;
                style.alignment = TextAnchor.MiddleCenter;
                Handles.Label(Med_Waypoints[i].transform.position + Vector3.up * 0.7f, Med_Waypoints[i].name, style);

                // Draw lines to represent path script between GameObjects
                if (i < Small_Waypoints.Length - 1)
                {
                    Gizmos.color = Color.gray;
                    Gizmos.DrawLine(Med_Waypoints[i].transform.position, Med_Waypoints[i + 1].transform.position);   
                }
            }
        }

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
                if (i < Small_Waypoints.Length - 1)
                {
                    Gizmos.color = Color.gray;
                    Gizmos.DrawLine(Large_Waypoints[i].transform.position, Large_Waypoints[i + 1].transform.position);   
                }
            }
        }
    }
}
 */