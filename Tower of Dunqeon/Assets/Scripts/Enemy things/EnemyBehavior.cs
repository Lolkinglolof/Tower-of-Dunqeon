using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] LayerMask wallMask;
    private bool goalReached = true;
    [SerializeField] float moveSpeed = 200, detectionRange = 5, engagementRange = 1;
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
        if (Physics.Raycast(transform.position, (player.transform.position - transform.position).normalized, out RaycastHit hit, detectionRange) && hit.collider.gameObject.CompareTag("Player"))
        {
            goalReached = false;
            goal = player.transform.position;
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
            if ((goal - gameObject.transform.position).magnitude < engagementRange)

            {
                goalReached = true;
            }
            Vector3 direction = goal - gameObject.transform.position;
            transform.LookAt(new Vector3(goal.x, transform.position.y, goal.z));
            direction.y = 0;
            Vector3 movementVector = direction.normalized * moveSpeed * Time.deltaTime;
            //Debug.Log(movementVector);
            body.AddForce(movementVector);
            
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
