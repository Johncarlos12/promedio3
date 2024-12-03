using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace promedio3
{
    public class GetScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI usernameText;
        [SerializeField] private TextMeshProUGUI scoreText;
        private GetScoreController controller;


        private void Awake()
        {
            controller = GetComponent<GetScoreController>();
            controller.Execute(GameData.username, OnCallback);
        }

        private void OnCallback(GetScoreModel data)
        {
            scoreText.text = $"Score: {Enemy.score}";
            usernameText.text = $"Username: {GameData.username}";
        }       
    }
}