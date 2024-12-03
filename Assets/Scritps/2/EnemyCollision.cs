using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace promedio3
{
    public class EnemyCollision : MonoBehaviour
    {
        [SerializeField] private string sceneName = "3"; 

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Base"))
            {
                SceneManager.LoadScene(sceneName); 
            }
        }
    }
}
