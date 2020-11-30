using UnityEngine;

public class PlayerMoveTurn : MonoBehaviour
{
    private float vertical = 0;
    private float horizontal = 0;
    private bool runKeyDown = false;
    private Animator animator;
    public float rotateSpeed = 1;
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {       
        // get forward / backward movement from Up/Down/W/S
        vertical = Input.GetAxis("Vertical");

        // get turn movement from Left/Right/A/D
        horizontal = Input.GetAxis("Horizontal");

        // test for RUN / JUMP keys
        runKeyDown = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

    }

    void FixedUpdate()
    {
        animator.SetFloat("Speed", vertical);
        animator.SetBool("Run", runKeyDown);
        
        // Turn
        transform.Rotate(0, horizontal * rotateSpeed, 0);
    }
}