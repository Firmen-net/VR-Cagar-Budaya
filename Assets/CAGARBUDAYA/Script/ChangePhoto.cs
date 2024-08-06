using Doozy.Runtime.Reactor.Animators;
using System.Collections;
using UnityEngine;

public class ChangePhoto : MonoBehaviour
{
    public UIAnimator animator;
    public float delay = 0.5f;
    public GameObject[] photo;
    private int currentPhoto;
    public ChangeText ChangeText;

    private void Start()
    {
        currentPhoto = 0;
    }

    public void StartFade()
    {
        animator.Play();
    }

    private IEnumerator DelayChangePhoto(int number)
    {
        yield return new WaitForSeconds(delay);
        photo[number].SetActive(true);
        photo[currentPhoto].SetActive(false);
        currentPhoto = number;
    }

    public void StartChangePhoto(int number)
    {
        StartFade();
        ChangeText.DisableText();
        StartCoroutine(DelayChangePhoto(number));
    }
}