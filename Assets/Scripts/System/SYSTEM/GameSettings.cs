using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour {

    public Vector3 StartPosition = new Vector3(0, 0, 0);
    public GameObject PlayerPrefab;

	void Start () {
        if (StartPosition == Vector3.zero)
            Debug.LogError("Please define a StartPosition in GameSettings gameObject");

        if (PlayerPrefab == null)
            Debug.LogError("Please assign a CharacterPrefab in GameSettings gameObject");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
