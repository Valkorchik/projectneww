
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement; 

public class sborka : MonoBehaviour
{
    public void prosmotrsite()
    {
        SceneManager.LoadScene("button2");
    }
    public void mirea()
    {
        Application.OpenURL("https://www.ikea.com/ru/ru/customer-service/services/assembly/");
    }
}