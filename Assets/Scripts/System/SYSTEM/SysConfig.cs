using UnityEngine;
using System.Collections;

public class SysConfig : MonoBehaviour
{

    #region SceneNames
    public const string IntroSceneName = "Intro";
    public const string MainMenuSceneName = "MainMenu";
    public const string NewGameSceneName = "LoadingNewGame";
    public const string LoadGameSceneName = "LoadGame";
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
}
