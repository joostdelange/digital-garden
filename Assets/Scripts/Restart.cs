using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject instructions1;
    public GameObject instructions2;
    public GameObject instructions3;
	public GameObject instructions4;
	public GameObject instructions5;
    
    public void RestartGame() {
        SceneManager.LoadScene("Main");
    }

	public void ShowInstructions1() {
		instructions1.SetActive(true);
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
		instructions4.SetActive(true);
    }

	public void DismissInstructions4()
	{
		instructions4.SetActive(false);
		instructions5.SetActive(true);
	}

	public void DismissInstructions5()
	{
		instructions5.SetActive(false);
	}
}
