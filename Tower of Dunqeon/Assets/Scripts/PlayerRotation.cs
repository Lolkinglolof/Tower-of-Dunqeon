using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ray mouseWorldRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(mouseWorldRay, out RaycastHit hit);
        player.transform.LookAt(hit.point);
    }
}
