using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    void Update()
    { 
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Ensure the object stays in the same plane as the camera.

        transform.position = mousePosition;
    }
    private void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.name == "Wall")
        {
            //transform.position = spawnPoint;
            var currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);
            print(currentScene);
        }
    }
}
