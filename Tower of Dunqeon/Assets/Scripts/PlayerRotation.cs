using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;
    private GameObject player;
    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ray mouseWorldRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(mouseWorldRay, out RaycastHit hit, 100f, layerMask);
        direction = hit.point - transform.position;
        Vector3 lookPlace = new(hit.point.x,player.transform.position.y,hit.point.z);
        player.transform.LookAt(lookPlace);
    }
}
