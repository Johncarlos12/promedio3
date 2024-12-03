using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace promedio3
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private float speed;
        private Rigidbody rb;
        private int hitCount = 0; 
        [SerializeField] private int maxHits = 3; 

        public int value = 25;

        public static int score = 0; 

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            rb.velocity = Vector3.left * speed;
        }

        public void TakeHit()
        {
            hitCount++; 

            if (hitCount >= maxHits)
            {
                Die(); 
            }
        }

        private void Die()
        {
            Stats.Money += value;
            score++;
            Destroy(gameObject); 
        }
    }
}




