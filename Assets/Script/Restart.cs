using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
   
    public GameObject Restart_Button;

   
    public void gamestart()
    {
       //Time.timeScale = 1;
        SceneManager.LoadScene("Scene1");
    }
}
