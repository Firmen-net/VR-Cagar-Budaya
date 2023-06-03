using Doozy.Runtime.Reactor.Animators;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangePhoto : MonoBehaviour
{
    /* public static ChangePhoto Instance;*/

    // public int photoNumber;
    public UIAnimator animator;

    public float delay = 0.5f;
    public GameObject[] photo;
    private int currentPhoto;

    /* private void Awake()
     {
         if (Instance != null && Instance != this)
         {
             Destroy(this);
         }
         else
         {
             Instance = this;
         }
     }*/

    private void Start()
    {
        currentPhoto = 0;
    }

    public void StartFade()
    {
        animator.Play();
        //nim.Play();
    }

    public void StartChangePhoto(int number)
    {
        StartFade();
        Debug.Log("Activated " + number);
        StartCoroutine(DelayChangePhoto(number));
    }

    private IEnumerator DelayChangePhoto(int number)
    {
        yield return new WaitForSeconds(delay);
        photo[number].SetActive(true);
        photo[currentPhoto].SetActive(false);
        currentPhoto = number;
    }
}