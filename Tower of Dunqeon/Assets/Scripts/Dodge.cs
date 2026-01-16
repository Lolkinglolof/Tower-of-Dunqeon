using UnityEngine;

public class Dodge : MonoBehaviour
{
    Animator animator;
    [SerializeField] GameObject wep, shield;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Dodge");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Dodge"))
        {
            wep.SetActive(false);
            shield.SetActive(false);
        }
        else
        {
            wep.SetActive(true);
            shield.SetActive(true);
        }
    }
    public void BeginIFrame()
    {
        gameObject.GetComponent<PlayerHealth>().IFrameActive = true;
    }
    public void EndIFrame()
    {
        gameObject.GetComponent<PlayerHealth>().IFrameActive = false;
    }

}
