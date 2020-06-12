using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu 3D");
    }

    public void SituScene()
    {
        SceneManager.LoadScene("SceneSitu");
    }

    public void CafeScene()
    {
        SceneManager.LoadScene("SceneCafe");
    }

    public void PilihScene()
    {
        SceneManager.LoadScene("Scene361");
    }
}
