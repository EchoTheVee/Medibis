using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Sceneswitch : MonoBehaviour
{
    public Scene Level0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void LevelChange(string Level0)
    {
        SceneManager.LoadScene(Level0);
    }
    public void LevelSelect(string LevelSelect)
    {
        SceneManager.LoadScene(LevelSelect);
    }
    public void SelectLevel(string LevelSelect)
    {
        SceneManager.LoadScene(LevelSelect);
    }
    public void ClickExit()
    {
        Application.Quit();
    }
}
