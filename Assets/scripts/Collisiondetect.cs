using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnim;
    [SerializeField] AudioSource collisionFX;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject fadeOut;

    [Header("Game Over UI Elements")]
    public GameObject gameOverPanel;  

    void OnTriggerEnter(Collider other)
    {
        
        StartCoroutine(CollisionEnd());
    }

    IEnumerator CollisionEnd()
    {
        collisionFX.Play();  
        thePlayer.GetComponent<PlayerMovement>().enabled = false;  
        playerAnim.GetComponent<Animator>().Play("Stumble");  
        mainCam.GetComponent<Animator>().Play("CollisionCam");  

        yield return new WaitForSeconds(1);  

        
        gameOverPanel.SetActive(true);

        yield return new WaitForSeconds(3);  

        fadeOut.SetActive(true);  
    }

    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
        gameOverPanel.SetActive(false);  
    }

    
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);  
    }
}
