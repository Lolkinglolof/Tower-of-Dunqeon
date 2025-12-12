using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private bool goalReached = false;
    private float moveSpeed = 1;
    private Vector3 goal;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (goalReached)
        {
            goalReached = false;
            float angle = Random.Range(0, 359.9f);
            float distance = Random.Range(0, 5);
            goal = Quaternion.AngleAxis(angle, Vector3.up) * new Vector3(distance, 0, 0);
        }
        else
        {

        }
    }
}
