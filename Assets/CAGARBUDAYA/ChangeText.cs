using Doozy.Runtime.Reactor.Animators;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public UIAnimator animator;
    public GameObject[] text;
    private bool enable = true;

    public void StartChangeText(int number)
    {
        if (enable)
        {
            animator.Play();
            text[number].SetActive(true);
            enable = false;
        }
        else
        {
            animator.Play(Doozy.Runtime.Reactor.PlayDirection.Reverse);

            StartCoroutine(DelayDisableText(number));
            enable = true;
        }
    }

    private IEnumerator DelayDisableText(int number)
    {
        yield return new WaitForSeconds(0.5f);
        text[number].SetActive(false);
    }
}