
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillDragon : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 5.6)
        {
            SceneManager.LoadScene(0);
        }
        if (transform.position.y < -5.5) {
            SceneManager.LoadScene(0);
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
