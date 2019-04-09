using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject instructions1;
    public GameObject instructions2;
    public GameObject instructions3;
    
    public void RestartGame() {
        SceneManager.LoadScene("Main");
    }

    public void DismissInstructions1()
    {
        instructions1.SetActive(false);
        instructions2.SetActive(true);
    }
    
    public void DismissInstructions2()
    {
        instructions2.SetActive(false);
        instructions3.SetActive(true);
    }
    
    public void DismissInstructions3()
    {
        instructions3.SetActive(false);
    }
}