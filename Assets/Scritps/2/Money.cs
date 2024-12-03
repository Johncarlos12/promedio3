using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace promedio3
{
    public class Money : MonoBehaviour
    {
        public TMP_Text moneyText;
        
        void Update () 
        {
            moneyText.text = "Money: " + Stats.Money.ToString();
        }
    }
}


