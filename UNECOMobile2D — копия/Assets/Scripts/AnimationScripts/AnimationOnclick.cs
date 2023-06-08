using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationOnclick : MonoBehaviour
{
   Animator animator;
    private void AnimatorOnclick()
    {
        if (Input.GetMouseButton(0))
        {
            animator = GetComponent<Animator>();

        }
    }
}
