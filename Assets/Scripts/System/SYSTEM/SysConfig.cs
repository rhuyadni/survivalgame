﻿using UnityEngine;
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
    public const float HealthPerLevel = 1.2f;
    public const float ThirstyPerLevel = 1.1f;
    public const float HungryPerLevel = 1.1f;
    public const float StaminaPerLevel = 1.1f;
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

    public static void SavePlayer(string name, int health, int thirsty, int hungry, int stamina, int level, int exp) {
        PlayerPrefs.SetString(SaveNameStr, name);
        PlayerPrefs.SetInt(SaveHealthStr, health);
        PlayerPrefs.SetInt(SaveThirstyStr, thirsty);
        PlayerPrefs.SetInt(SaveHungryStr, hungry);
        PlayerPrefs.SetInt(SaveStaminaStr, stamina);
        PlayerPrefs.SetInt(SaveLevelStr, level);
        PlayerPrefs.SetInt(SaveExpStr, exp);
    }

    public string LoadPlayerName() {
        string tempName = PlayerPrefs.GetString(SaveNameStr);
        return tempName;
    }

    public int LoadPlayerLevel() {
        int tempLv = PlayerPrefs.GetInt(SaveLevelStr);

        return tempLv;
    }
}
