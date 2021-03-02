using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
  
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void AnaSayfa()
    {
        SceneManager.LoadScene("Sahne");
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
