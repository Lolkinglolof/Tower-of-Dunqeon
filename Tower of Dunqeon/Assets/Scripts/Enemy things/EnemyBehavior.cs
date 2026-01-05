using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] LayerMask wallMask;
    private bool goalReached = true;
    private float moveSpeed = 1, detectionRange = 5, engagementRange = 1;
    private Vector3 goal;
    private Rigidbody body;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.magnitude - transform.position.magnitude < detectionRange)
        {
            Vector3 rayDirection = (player.transform.position - transform.position).normalized;
            if (!Physics.Raycast(transform.position, rayDirection, detectionRange, wallMask))
            {
                goalReached = false;
                goal = player.transform.position;
            }
        }
        if (goalReached)
        {
            goalReached = false;
            float angle = Random.Range(0, 359.9f);
            float distance = Random.Range(0, 5);
            goal = Quaternion.AngleAxis(angle, Vector3.up) * new Vector3(distance, 0, 0) + transform.position;
        }
    }
    private void FixedUpdate()
    {
        if (!goalReached)
        {
            Vector3 direction = goal - gameObject.transform.position;
            direction.y = 0;
            Vector3 movementVector = direction.normalized * moveSpeed * Time.deltaTime;
            body.AddForce(movementVector);

            if ((goal - gameObject.transform.position).magnitude < engagementRange)

            {
                goalReached = true;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            goalReached = true;
        }
    }
}
