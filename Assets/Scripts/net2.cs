using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class net2 : MonoBehaviour
{
    public string url;

    public void OnButtomUrlClick()
    {
        Application.OpenURL(url);
    }
}