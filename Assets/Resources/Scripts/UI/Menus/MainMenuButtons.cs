using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour {

    public GameObject PlayerNameInput;
    public GameObject LoadGameButton;
    public GameObject LoadGameButtonTxt;

    public void Webpage()
    {
        Application.OpenURL("URL DA PAGE");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        string tempPname = PlayerNameInput.GetComponent<InputField>().text;

        SysConfig.SavePlayer(tempPname, 
            SysConfig.StartHealth, 
            SysConfig.StartThirsty, 
            SysConfig.StartHungry, 
            SysConfig.StartStamina, 
            SysConfig.StartLevel, 
            SysConfig.StartExperience
        );
        
        Application.LoadLevel(SysConfig.NewGameSceneName);
    }

    public void LoadGame() {
        string tempName = PlayerPrefs.GetString(SysConfig.SaveNameStr);
        int tempLv = PlayerPrefs.GetInt(SysConfig.SaveLevelStr);

        if (tempName != "" && tempLv >= 1)
        {
            string tempVal = tempName + " Lv: " + tempLv;

            LoadGameButton.SetActive(true);

            LoadGameButtonTxt.GetComponent<Text>().text = tempVal;
        }
    }

    public void LoadGameWorld()
    {
        Application.LoadLevel(SysConfig.LoadGameSceneName);
    }

}
