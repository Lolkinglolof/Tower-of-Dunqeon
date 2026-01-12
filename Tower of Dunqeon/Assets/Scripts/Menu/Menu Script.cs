using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit, 100))
            {
                if (hit.collider.CompareTag("Play"))
                {
                    SceneManager.LoadScene(1);
                }
                else if (hit.collider.CompareTag("Exit"))
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
