using UnityEngine;

public class AnimationPlayer2 : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool keysPressed =
            Input.GetKey(KeyCode.N) &&
            Input.GetKey(KeyCode.M);

        if (keysPressed)
        {
            animator.SetTrigger("PlaySpecial");
        }
    }
}