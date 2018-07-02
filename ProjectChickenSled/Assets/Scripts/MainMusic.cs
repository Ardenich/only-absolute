using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMusic : MonoBehaviour
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
        if (SceneManager.GetActiveScene().name == "Trial")
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            Destroy(this.gameObject);
        }
    }
}
