using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePhotoOnselect : MonoBehaviour
{
    public int photoNumbers;

    public void ChangePhotoOnCLick(int number)
    {
        Debug.Log("Activated" + photoNumbers);
        Debug.Log(number);
        //ChangePhoto.Instance.photo[photoNumbers].SetActive(true);
        //ChangePhoto.Instance.StartChangePhoto();
    }
}