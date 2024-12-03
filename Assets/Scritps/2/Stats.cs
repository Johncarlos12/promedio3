using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace promedio3
{
    public class Stats : MonoBehaviour
    {
        public static int Money;
        public int startMoney = 150;

        void Start ()
        {
            Money = startMoney;
        }
    }
}