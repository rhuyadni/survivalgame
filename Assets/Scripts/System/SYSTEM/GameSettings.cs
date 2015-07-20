using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{

    #region UI Objects
    //value ui labels
    public GameObject NameTextLabel;
    public GameObject LevelTextLabel;
    public GameObject ExpTextLabel;

    //value ui bars
    public GameObject ExpValueBar;
    public GameObject HpValueBar;
    public GameObject ThValueBar;
    public GameObject HuValueBar;
    public GameObject StValueBar;
    #endregion

    #region Player Variables
    public Vector3 StartPosition = new Vector3(290, 6, 320);
    public GameObject PlayerPrefab;

    //dont edit before this line
    protected GameObject pc;
    #endregion

    #region Attributes Variables
    private static string tName = "";
    private static int tmaxHP = 1;
    private static int tcurHP = 1;

    private static int tmaxTH = 1;
    private static int tcurTH = 1;

    private static int tmaxHU = 1;
    private static int tcurHU = 1;

    private static int tmaxST = 1;
    private static int tcurST = 1;


    #endregion

    void Start () {
        if (StartPosition == Vector3.zero) {
            Debug.LogError("Please define a StartPosition in GameSettings gameObject");
            return;
        }

        if (PlayerPrefab == null) {
            Debug.LogError("Please assign a CharacterPrefab in GameSettings gameObject");
            return;
        }

        ShowCursorOnScreen(false);

        SpawnPlayer();


	}

    void SpawnPlayer()
    {
        pc = GameObject.Instantiate(PlayerPrefab, StartPosition, Quaternion.identity) as GameObject;
        pc.tag = "Player";
        pc.name = "PlayerCharacter";
    }

	void Update () {

	}

    public static void SetName(string name) {
        tName = name;
    }

    void SetUiName()
    {

    }

    public static void SetHealth(int curHp, int maxHp) {
        tmaxHP = maxHp;
        tcurHP = curHp;
    }

    public static void SetThirsty(int curTh, int maxTh) {
        tmaxTH = maxTh;
        tcurTH = curTh;
    }

    public static void SetHungry(int curHu, int maxHu) {
        
    }

    public static void ShowCursorOnScreen(bool val) {
        Cursor.visible = val;
    }


}
