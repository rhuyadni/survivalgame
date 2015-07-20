/// GameSettings.cs
/// Gabriel Dias Lopes, 20 july 2015
/// Basicly all game system and player stats is here
/// Changes can be make in SysConfig.cs Script.

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{

    #region UI Objects
    //value ui labels
    public GameObject NameTextLabel;
    //public GameObject LevelTextLabel;
    //public GameObject ExpTextLabel;

    //value ui bars
    //public GameObject ExpValueBar;
    public Slider HpValueBar;
    public Slider ThValueBar;
    public Slider HuValueBar;
    public Slider StValueBar;
    #endregion

    #region Player Variables
    public Vector3 StartPosition = new Vector3(290, 6, 320);
    public GameObject PlayerPrefab;

    //dont edit before this line
    protected GameObject pc;
    #endregion

    #region Modifiers Variables
    private int cHealth;
    private int cThirsty;
    private int cHungry;
    private int cStamina;
    private int walkspeed = 6;
    private CharacterMotor cm;
    private bool decreaseStamina = false;

    private float timer = 0;
    private float stTimer = 0;

    #endregion
    
    void Start () {
        #region Principal Prefabs Check
        if (StartPosition == Vector3.zero) {
            Debug.LogError("Please define a StartPosition in GameSettings gameObject");
            return;
        }

        if (PlayerPrefab == null) {
            Debug.LogError("Please assign a CharacterPrefab in GameSettings gameObject");
            return;
        }
        #endregion

        ShowCursorOnScreen(false);
        SetDefaults();

        SetName();

        SpawnPlayer();


	}

    void SetDefaults()
    {
        HpValueBar.maxValue = SysConfig.StartHealth;
        cHealth = SysConfig.StartHealth;

        ThValueBar.maxValue = SysConfig.StartThirsty;
        cThirsty = SysConfig.StartThirsty;

        HuValueBar.maxValue = SysConfig.StartHungry;
        cHungry = SysConfig.StartHungry;

        StValueBar.maxValue = SysConfig.StartStamina;
        cStamina = SysConfig.StartStamina;
    }

    void SpawnPlayer() {
        pc = GameObject.Instantiate(PlayerPrefab, StartPosition, Quaternion.identity) as GameObject;
        pc.tag = "Player";
        pc.name = "PlayerCharacter";

        cm = pc.GetComponent<CharacterMotor>();
    }

    void Update()
    {
        #region Decrease Vitals Timer
        timer += Time.deltaTime * 1;

        if (timer >= SysConfig.DecreaseRate) {
            if (cThirsty <= 0) {
                cHealth -= SysConfig.HealthDecrease;
                //timer = 0;
            } else {
                cThirsty -= SysConfig.ThirstyDecrease;
                //timer = 0;
            }

            if (cHungry <= 0) {
                cHealth -= SysConfig.HealthDecrease;
                //timer = 0;
            } else {
                cHungry -= SysConfig.HungryDecrease;
                //timer = 0;
            }

            timer = 0;
        }
        #endregion

        #region Decrease Stamina Timer
        stTimer += Time.deltaTime * 1;

        if (stTimer >= SysConfig.DecreaseStaminaRate)
        {
            if (decreaseStamina == true)
            {
                cStamina -= SysConfig.StaminaDecrease;
                stTimer = 0;
            }
            else
            {
                if (cStamina < (int)StValueBar.maxValue)
                {
                    cStamina += SysConfig.StaminaDecrease;
                    stTimer = 0;
                }
            }
        }
        #endregion

        if (Input.GetKeyDown(KeyCode.LeftShift) && cStamina > SysConfig.StaminaDecrease) {
                decreaseStamina = true;
                walkspeed = SysConfig.RunSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift)) {
            walkspeed = SysConfig.WalkSpeed;
            decreaseStamina = false;
        }

        Run();
    }

	void LateUpdate () {
        VitalsModifiers();        
	}

    void VitalsModifiers() {
        HpValueBar.value = cHealth;
        ThValueBar.value = cThirsty;
        HuValueBar.value = cHungry;
        StValueBar.value = cStamina;
    }

    void Run() {
        if (cStamina < SysConfig.StaminaDecrease)
        {
            cm.movement.maxForwardSpeed = SysConfig.WalkSpeed;
        }
        else
        {
            cm.movement.maxForwardSpeed = walkspeed;
        }
    }

    void SetName() {
        string temp = PlayerPrefs.GetString(SysConfig.SaveNameStr);

        if (temp != null) {
            NameTextLabel.GetComponent<Text>().text = temp;
        } else {
            SaveInfoCorrupted();
        }
    }

    void SetHealth(int temp) {
        HpValueBar.value = temp;
    }

    void SaveInfoCorrupted() {
        Application.LoadLevel(SysConfig.MainMenuSceneName);
    }

    public static void ShowCursorOnScreen(bool val) {
        Cursor.visible = val;
    }


}
