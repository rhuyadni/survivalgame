using UnityEngine;
using System.Collections;

public class MainMenuButtons : MonoBehaviour {

    public void Webpage()
    {
        Application.OpenURL("URL DA PAGE");
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
