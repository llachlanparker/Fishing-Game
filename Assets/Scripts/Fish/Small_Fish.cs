using UnityEngine;

public class Small_Fish : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private Small_Path currentPath;

    private Vector3 _targetPosition;

    // Find target for fish before OnEnable
    private void Awake()
    {
        currentPath = GameObject.Find("Small_Path").GetComponent<Small_Path>();
    }

    // Find path from target for fish afer awake
    private void OnEnable()
    {
        _targetPosition = currentPath.GetPosition(0);
    }

    // Update is called once per frame
    void Update()
    {
        // Move towards target position
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, moveSpeed * Time.deltaTime);
    }
}
