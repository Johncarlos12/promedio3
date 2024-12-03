using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace promedio3
{
    public class BuildManager : MonoBehaviour
    {
        public static BuildManager instance;

        void Awake ()
        {
            if (instance != null)
            {
                Debug.LogError("Mas de una BuildManager en escena");
                return;
            }
            instance = this;
        }

        public GameObject towerPrefab;
        public GameObject towerTwoPrefab;
        public GameObject towerThreePrefab;

        private TowerCost towerToBuild;
        
        public bool CanBuild {get{return towerToBuild != null;}}
        public bool HasMoney {get{return Stats.Money >= towerToBuild.cost;}}


        public void BuilTowerOn (Node node)
        {
            if (Stats.Money < towerToBuild.cost)
            {
                Debug.Log("No tienes suficiente dinero!");
                return;
            }

            Stats.Money -= towerToBuild.cost;

            GameObject tower = (GameObject)Instantiate(towerToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
            node.tower = tower;
            Debug.Log("Torre Construida! Dinero Restante: " + Stats.Money);

        }

        public void SelectTowerToBuild (TowerCost tower)
        {
            towerToBuild = tower;
        }
    }
}

 

