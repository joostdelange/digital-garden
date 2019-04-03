using UnityEngine;
using UnityEngine.SceneManagement;
     
public class Restart : MonoBehaviour
{
//    public GameObject other;
    public int previousNumber;
     
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private int ReturnRandomNumber()
    {
        while (true)
        {
            var r = new System.Random();
            var randomNumber = r.Next(0, 4);

            if (previousNumber == randomNumber)
            {
                continue;
            }

            previousNumber = randomNumber;
            return randomNumber;
            break;
        }
    }

    public void DestroyLatestComponent()
    {
        Debug.Log(ReturnRandomNumber());
//        Destroy(other);
    }
}