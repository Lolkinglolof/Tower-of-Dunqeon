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
            Debug.Log("click");
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit, 100))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.CompareTag("Play"))
                {
                    SceneManager.LoadScene(1);
                }
                else if (hit.collider.gameObject.CompareTag("Exit"))
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
