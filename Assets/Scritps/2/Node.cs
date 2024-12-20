using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace promedio3
{
    public class Node : MonoBehaviour
    {
        public Color hoverColor;
        public Color notEnoughMoneyColor;
        public Vector3 positionOffset;

        [Header("Optional")]
        public GameObject tower;
        private Renderer rend;
        private Color startColor;

        BuildManager buildManager;

        void Start ()
        {
            rend = GetComponent<Renderer>();
            startColor = rend.material.color;

            buildManager = BuildManager.instance;
        }

        public Vector3 GetBuildPosition ()
        {
            return transform.position + positionOffset;
        }

        void OnMouseDown ()
        {
            if (EventSystem.current.IsPointerOverGameObject())
            
                return;

            if (!buildManager.CanBuild)
            
                return;
            
            if (tower != null)
            {
                return;
            }

            buildManager.BuilTowerOn (this);
        }


        void OnMouseEnter()
        {
            if (EventSystem.current.IsPointerOverGameObject())
            
                return;
            
            if (!buildManager.CanBuild)
            
                return;

            if (buildManager.HasMoney)
            {
                rend.material.color = hoverColor;
            }

            else
            {
                rend.material.color = notEnoughMoneyColor;
            }
        }

        void OnMouseExit ()
        {
            rend.material.color = startColor;
        }
    }
}