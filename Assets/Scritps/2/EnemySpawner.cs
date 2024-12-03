using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace promedio3
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private float spawnDelay;
        [SerializeField] private GameObject enemyPrefab;


        private void Start()
        {
            StartCoroutine(Spawn());
        }

        IEnumerator Spawn()
        {
            while(true)
            {
                GameObject obj = Instantiate(enemyPrefab);
                obj.transform.position=transform.position;
                obj.transform.position += Vector3.right * Random.Range(-3, 3);
                yield return new WaitForSeconds(spawnDelay);
            }
        }
    }

}