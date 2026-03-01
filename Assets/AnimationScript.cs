using UnityEngine;

public class SpecialAnimationTrigger : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool mousePressed =
            Input.GetMouseButton(0) &&   // Left mouse
            Input.GetMouseButton(1);     // Right mouse

        if (mousePressed)
        {
            animator.SetTrigger("Player1");
        }
    }
}