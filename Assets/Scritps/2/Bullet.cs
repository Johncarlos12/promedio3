using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace promedio3
{
    public class Bullet : MonoBehaviour
    {
        private Transform target;
        public float speed = 50f;

        public void Seek(Transform _target)
        {
            target = _target;
        }

        void Update ()
        {
            if (target == null)
            {
                Destroy(gameObject);
                return;
            }

            Vector3 dir = target.position - transform.position;
            float distanceThisFrame = speed * Time.deltaTime;

            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                return;
            }

            transform.Translate (dir.normalized * distanceThisFrame, Space.World);

        }
        
        void HitTarget()
        {
            Enemy enemy = target.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeHit(); 
            }
            
            Destroy(gameObject); 
        }
    }
}

