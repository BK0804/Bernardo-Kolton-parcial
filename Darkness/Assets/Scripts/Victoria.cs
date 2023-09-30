using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)

    {
        if (collision.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
