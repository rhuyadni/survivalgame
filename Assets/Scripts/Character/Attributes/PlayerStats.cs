using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

    #region dont edit anything before this line
    private string pName = "";

    //level and cur experience
    private int pLevel = 1;
    private int pCurEx = 1;

    //max and cur health points
    private int pMaxHp = 1;
    private int pCurHp = 1;

    //max and cur thirsty
    private int pMaxTh = 1;
    private int pCurTh = 1;

    //max and cur hungry
    private int pMaxHu = 1;
    private int pCurHu = 1;

    //max and cur stamina
    private int pMaxSt = 1;
    private int pCurSt = 1;
    #endregion

    void Start () {
        LoadAttributes();        
	}

    void LoadAttributes() {
        //load player name
        pName = SysConfig.LoadPlayerName();

        //load skills base - level & exp
        pLevel = SysConfig.LoadPlayerLevel();
        pCurEx = SysConfig.LoadPlayerExp();

        //load base attributes & define cur values
        pMaxHp = SysConfig.LoadPlayerHealth();
        pCurHp = pMaxHp;
        pMaxTh = SysConfig.LoadPlayerThirsty();
        pCurTh = pMaxTh;
        pMaxHu = SysConfig.LoadPlayerHungry();
        pMaxHu = pCurHu;
        pMaxSt = SysConfig.LoadPlayerStamina();
        pCurSt = pMaxSt;

        DefineUiValues();
    }

    void DefineUiValues() {
        GameSettings.SetName(pName);
        GameSettings.SetHealth(pCurHp, pMaxHp);
        GameSettings.SetThirsty(pCurTh, pMaxTh);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
