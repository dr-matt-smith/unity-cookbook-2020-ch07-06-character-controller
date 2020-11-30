using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float vertical = 0;
    private bool runKeyDown = false;
    private Animator animator;
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {       
        // get forward / backward movement from Up/Down/W/S
        vertical = Input.GetAxis("Vertical");

        // test for RUN / JUMP keys
        runKeyDown = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

    }

    void FixedUpdate()
    {
        animator.SetFloat("Speed", vertical);
        animator.SetBool("Run", runKeyDown);        
    }
}