using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{


    public void LoginButton (string Landing_Page)
    {
        SceneManager.LoadScene(Landing_Page);
    }

}
