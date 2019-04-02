using UnityEngine;
using UnityEngine.SceneManagement;
     
public class Restart : MonoBehaviour
{
    public GameObject other;
     
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void DestroyLatestComponent()
    {
        Destroy(other);
    }
}