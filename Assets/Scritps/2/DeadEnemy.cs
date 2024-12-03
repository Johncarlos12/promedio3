using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace promedio3
{
    public class DeadEnemy : MonoBehaviour
    {
        public TMP_Text deadEnemyText;

        void Update()
        {
            deadEnemyText.text = "Dead Enemy: " + Enemy.score;
        }
    }
}

