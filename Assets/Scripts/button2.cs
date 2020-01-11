using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button2 : MonoBehaviour
{
    public void prosmotrsite()
    {
        SceneManager.LoadScene("button2");
    }
    public void mirea()
    {
        Application.OpenURL("https://www.ikea.com/ru/ru/customer-service/dostavka-i-samovyvoz-pub30f2c801");
    }
}