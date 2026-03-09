using UnityEngine;

public class Small_Fish : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private Small_Path currentPath;

    private Vector3 _targetPosition;
    private int _currentWaypoint;

    // Find target for fish before OnEnable
    private void Awake()
    {
        currentPath = GameObject.Find("Small_Path").GetComponent<Small_Path>();
    }

    // Find path from target for fish afer awake
    private void OnEnable()
    {
        _currentWaypoint = 0;
        _targetPosition = currentPath.GetPosition(_currentWaypoint);
    }

    // Update is called once per frame
    void Update()
    {
        // Move towards target position
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, moveSpeed * Time.deltaTime);

        // Set new target position when waypoint reached
        float relativeDistance = (transform.position - _targetPosition).magnitude;
        if (relativeDistance < 0.1f)
        {
            if (_currentWaypoint < currentPath.Small_Waypoints.Length -1)
            {
            _currentWaypoint++;     // Increase waypoint int by 1
            _targetPosition = currentPath.GetPosition(_currentWaypoint);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}
