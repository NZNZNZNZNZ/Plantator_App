using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Go_2_NewPlant : MonoBehaviour
{
    public void newPlant_button(string createNewPlant)
	{
        SceneManager.LoadScene( createNewPlant);
	}

}
