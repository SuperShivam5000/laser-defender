using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] float sceneLoadDelay = 1;
    ScoreKeeper scoreKeeper;
    void Awake(){
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    public void LoadGame(){
        scoreKeeper.ResetScore();
        SceneManager.LoadScene("Game");
    }
    public void LoadMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadGameOver(){
        StartCoroutine(WaitAndLoad("GameOver", sceneLoadDelay));
    }
    IEnumerator WaitAndLoad(string sceneName, float delay){
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);

    }
    public void QuitGame(){
        Debug.Log("Quitting");
        Application.Quit();
    }
}
