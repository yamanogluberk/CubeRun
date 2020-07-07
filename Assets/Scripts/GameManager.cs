using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isGameEnded = false;
    
    public GameObject EndLevelPanel;
    public GameObject RestartLevelPanel;
    
    
    public void LevelComplete()
    {
        EndLevelPanel.SetActive(true);
    }
    
    public void EndGame()
    {
        if (!isGameEnded)
        {
            isGameEnded = true;
            RestartLevelPanel.SetActive(true);
        }
    }
    
}
