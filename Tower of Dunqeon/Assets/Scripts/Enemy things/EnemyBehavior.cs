using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private bool goalReached = true;
    private float moveSpeed = 1;
    private Vector3 goal;
    private Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
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
            if ((goal - gameObject.transform.position).magnitude < new Vector3(1, 1, 1).magnitude)
            {
                goalReached = true;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            goalReached = true;
        }
    }
}
