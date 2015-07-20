using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

    public string SceneName = "";
    public float loadSceneDelay = 1.5f;

    void Start () {
        Invoke("CallScene", loadSceneDelay);
	}

    void CallScene()
    {
        Application.LoadLevel(SceneName);
    }
}
