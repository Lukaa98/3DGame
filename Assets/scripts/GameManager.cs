
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

bool gameHasEnded = false;

public float restartDelay = 2f;

public GameObject completelevelUI;

public void CompleteLevel ()
{
    completelevelUI.SetActive(true);
}

public void EndGame () 
 { 
     if (gameHasEnded == false);
     {
        gameHasEnded =  true;
        Debug.Log("game over"); 
        Invoke ("Restart", restartDelay);//calling restart code down
     }
    
 }

    void Restart()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}