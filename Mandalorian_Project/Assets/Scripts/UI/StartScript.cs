using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{

    public void OnStartBottomClick()
    {
        SceneManager.LoadScene(1);
    }
    public void OnQuitBottomClick()
    {
        Application.Quit();
    }




}
