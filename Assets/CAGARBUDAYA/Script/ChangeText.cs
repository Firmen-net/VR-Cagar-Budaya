using Doozy.Runtime.Reactor.Animators;
using System.Collections;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public UIAnimator animator;
    public GameObject[] text;
    private bool enable = true;
    private int currentText;

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

    public void DisableText()
    {
        enable = true;
        animator.ResetToStartValues();
        for (int i = 0; i < text.Length; i++)
        {
            text[i].SetActive(false);
        }
    }

    private IEnumerator DelayDisableText(int number)
    {
        yield return new WaitForSeconds(0.5f);
        text[number].SetActive(false);
        if (number != 0)
        {
            text[number - 1].SetActive(false);
        }
    }
}