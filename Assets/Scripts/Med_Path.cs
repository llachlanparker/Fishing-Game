using UnityEngine;
using UnityEditor;

public class Med_Path : MonoBehaviour
{
    // Use Waypoints GameObject prefab
    public GameObject[] Med_Waypoints;  // Path for medium fish

    // Move fish to waypoints
    public Vector3 GetPosition(int index)
    {
        return Med_Waypoints[index].transform.position;

    }

    // Draw Gizmos to see GameObject paths and labels
    private void OnDrawGizmos()
    {
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
                if (i < Med_Waypoints.Length - 1)
                {
                    Gizmos.color = Color.gray;
                    Gizmos.DrawLine(Med_Waypoints[i].transform.position, Med_Waypoints[i + 1].transform.position);   
                }
            }
        }
    }
}
