using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStage1 : MonoBehaviour {

    public void StartScene()
    {
        SceneManager.LoadScene("Trial");
    }
}
