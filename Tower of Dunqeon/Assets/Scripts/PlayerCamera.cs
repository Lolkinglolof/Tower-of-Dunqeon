using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private GameObject player;
    [SerializeField] Vector3 cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = player.transform.position + cameraOffset;
        Camera.main.transform.LookAt(player.transform.position);
    }
}
