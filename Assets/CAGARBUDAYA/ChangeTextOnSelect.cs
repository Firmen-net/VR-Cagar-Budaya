using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTextOnSelect : MonoBehaviour
{
    public int textNumber;
    private bool enable = true;

    public void ChangeTextOnCLick()
    {
        Debug.Log("TextClicked");
        // ChangeText.Instance.StartChangeText(textNumber, enable);
        enable = !enable;
    }
}