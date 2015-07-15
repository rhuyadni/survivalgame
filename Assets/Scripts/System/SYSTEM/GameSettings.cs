using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour {

    public Vector3 StartPosition = new Vector3(290, 6, 320);
    public GameObject PlayerPrefab;

    //dont edit before this line
    protected GameObject pc;

	void Start () {
        if (StartPosition == Vector3.zero) {
            Debug.LogError("Please define a StartPosition in GameSettings gameObject");
            return;
        }

        if (PlayerPrefab == null) {
            Debug.LogError("Please assign a CharacterPrefab in GameSettings gameObject");
            return;
        }

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
}
