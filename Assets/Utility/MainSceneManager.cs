using UnityEngine.SceneManagement;

public class MainSceneManager
{
    private const int MainMenuIdx = 0;
    private const int FirstLevelIdx = 1;
    private const int LastLevelIdx = 4;

    private const int EndGameIdx = 5;

    public static void MainMenu()
    {
        SceneManager.LoadScene(MainMenuIdx);
    }

    public static void StartGame()
    {
        SceneManager.LoadScene(FirstLevelIdx);
    }

    public static void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void NextLevel()
    {
        int activeLevelIdx = SceneManager.GetActiveScene().buildIndex;
        if (activeLevelIdx == LastLevelIdx)

            EndGame();
        else
            SceneManager.LoadScene(activeLevelIdx + 1);
    }

    private static void EndGame()
    {
        SceneManager.LoadScene(EndGameIdx);
    }
}