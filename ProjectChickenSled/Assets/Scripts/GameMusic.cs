using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameMusic : MonoBehaviour
{

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Main Menu")
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "Stage Select")
        {
            Destroy(this.gameObject);
        }
    }
}