using UnityEngine;

public class Large_Fish : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private Large_Path currentPath;

    private Vector3 _targetPosition;

    // Find target for fish before OnEnable
    private void Awake()
    {
        currentPath = GameObject.Find("Large_Path").GetComponent<Large_Path>();
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
