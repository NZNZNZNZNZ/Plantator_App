using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reminder_Set : MonoBehaviour
{
   public void open_reminder_settings(string Reminder_Set)
	{
        SceneManager.LoadScene(Reminder_Set);
	}
}
