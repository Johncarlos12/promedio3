using UnityEngine;

namespace promedio3
{
    public class Shop : MonoBehaviour
    {
        public TowerCost tower;
        public TowerCost towerTwo;
        public TowerCost towerThree;

        BuildManager buildManager;

        void Start()
        {
            buildManager = BuildManager.instance;
        }
        public void SelectTower()
        {
            buildManager.SelectTowerToBuild(tower);
        }

        public void SelectTowerTwo()
        {
            buildManager.SelectTowerToBuild(towerTwo);
        }

        public void SelectTowerThree()
        {
            buildManager.SelectTowerToBuild(towerThree);
        }
    }
}



  
