using Doozy.Runtime.Reactor.Animators;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePhoto : MonoBehaviour
{
    public UIAnimator animator;

    public void StartFade()
    {
        animator.Play();
    }
}