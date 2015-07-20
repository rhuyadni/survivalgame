/// SysConfig.cs
/// Gabriel Dias Lopes, 20 july 2015
/// This class is responsable of all game variables and configurations
/// 
/// WARNING: DONT CHANGE ANYTHING IF YOU DONT KNOW WHAT IT DO.
/// Under development.

using UnityEngine;
using System.Collections;

public class SysConfig : MonoBehaviour
{

    #region SceneNames
    public const string IntroSceneName = "Intro";
    public const string MainMenuSceneName = "MainMenu";
    public const string NewGameSceneName = "LoadingNewGame";
    public const string LoadGameSceneName = "Game";
    #endregion

    #region Start Values
    public const int StartHealth = 1000;
    public const int StartThirsty = 500;
    public const int StartHungry = 500;
    public const int StartStamina = 300;
    public const int StartLevel = 1;
    public const int StartExperience = 1;
    public const int NewLevelExp = 300;
    #endregion

    #region Modifiers
    public const int HealthDecrease = 5;
    public const int ThirstyDecrease = 1;
    public const int HungryDecrease = 3;
    public const int StaminaDecrease = 15;

    public const int DecreaseRate = 3;
    public const int DecreaseStaminaRate = 1;

    public const int WalkSpeed = 5;
    public const int RunSpeed = 20;
    #endregion

    #region SaveStrings
    public const string SaveNameStr = "0x10001";
    public const string SaveHealthStr = "0x10002";
    public const string SaveThirstyStr = "0x10003";
    public const string SaveHungryStr = "0x10004";
    public const string SaveStaminaStr = "0x10005";
    public const string SaveLevelStr = "0x10006";
    public const string SaveExpStr = "0x10007";
    #endregion

    #region Save Player Attributes
    public static void SavePlayer(string name, int health, int thirsty, int hungry, int stamina, int level, int exp) {
        PlayerPrefs.SetString(SaveNameStr, name);
        PlayerPrefs.SetInt(SaveHealthStr, health);
        PlayerPrefs.SetInt(SaveThirstyStr, thirsty);
        PlayerPrefs.SetInt(SaveHungryStr, hungry);
        PlayerPrefs.SetInt(SaveStaminaStr, stamina);
        PlayerPrefs.SetInt(SaveLevelStr, level);
        PlayerPrefs.SetInt(SaveExpStr, exp);
    }

    #endregion

    #region Load PlayerAttributes
    public static string LoadPlayerName()
    {
        string tempName = PlayerPrefs.GetString(SaveNameStr);
        return tempName;
    }

    public static int LoadPlayerLevel() {
        int tempLv = PlayerPrefs.GetInt(SaveLevelStr);

        return tempLv;
    }

    public static int LoadPlayerHealth()
    {
        int tempval = PlayerPrefs.GetInt(SaveHealthStr);

        return tempval;
    }

    public static int LoadPlayerThirsty()
    {
        int tempval = PlayerPrefs.GetInt(SaveThirstyStr);

        return tempval;
    }

    public static int LoadPlayerHungry()
    {
        int tempval = PlayerPrefs.GetInt(SaveHungryStr);

        return tempval;
    }

    public static int LoadPlayerStamina()
    {
        int tempval = PlayerPrefs.GetInt(SaveStaminaStr);

        return tempval;
    }

    public static int LoadPlayerExp()
    {
        int tempval = PlayerPrefs.GetInt(SaveExpStr);

        return tempval;
    }

    #endregion
}
