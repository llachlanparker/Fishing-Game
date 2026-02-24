using UnityEngine;
using UnityEditor;

public class Path : MonoBehaviour
{
    // Use Waypoint GameObject prefab
    public GameObject[] Waypoints;

    // Draw Gizmos to see GameObject paths and labels
    private void OnDrawGizmos()
    {
        if (Waypoints.Length > 0)
        {
            for (int i = 0; i < Waypoints.Length; i++)
            {
                // Create labels and attach to correct GameObject
                GUIStyle style = new GUIStyle();
                style.normal.textColor = Color.white;
                style.alignment = TextAnchor.MiddleCenter;
                Handles.Label(Waypoints[i].transform.position + Vector3.up * 0.7f, Waypoints[i].name, style);

                // Draw lines to represent path script between GameObjects
                if (i < Waypoints.Length - 1)
                {
                    Gizmos.color = Color.gray;
                    Gizmos.DrawLine(Waypoints[i].transform.position, Waypoints[i + 1].transform.position);   
                }
            }
        }
    }
}
