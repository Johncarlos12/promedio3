using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace promedio3
{
    public class UploadScoreView : MonoBehaviour
    {
        [SerializeField] private Button sendScoreButton;
        private UploadScoreController controller;

        private void Awake()
        {
            sendScoreButton.onClick.AddListener(OnClicked);
            controller = GetComponent<UploadScoreController>();
        }

        private void OnClicked()
        {
            controller.Execute(GameData.username, Enemy.score, OnCallback);
        }

        private void OnCallback(MessageModel data)
        {
            if(data.message=="success")
            {
                GetComponent<GetRankingView>().Execute();
            }
            else
            {
                Debug.Log("Error!");
            }
        }
    }

}