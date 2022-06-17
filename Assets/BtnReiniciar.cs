using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnReiniciar : MonoBehaviour
{
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
