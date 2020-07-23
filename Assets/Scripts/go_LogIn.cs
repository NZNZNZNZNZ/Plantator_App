using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_LogIn : MonoBehaviour
{
    public void goLogIn(string Login_Page)
	{
        SceneManager.LoadScene(Login_Page);
	}
}
