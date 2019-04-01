using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gamespace
{
    public class CameraManager : MonoBehaviour
    {
        public Planet[] planetList;
        public GameObject orbitStar;
        public float orbitSpeed;
        public float orbitDistance;
        public float initialOrbitAngle = 0;
        public float rotationSpeed;
        public float orbitTime;

        private float orbitAngle;
        private int index=0;
        private float orbitTimer;


        void Start()
        {
            orbitSpeed = planetList[0].orbitSpeed;
            orbitDistance = planetList[0].orbitDistance + 20;
            orbitAngle = planetList[0].initialOrbitAngle;
            rotationSpeed = planetList[0].rotationSpeed;
            orbitTimer = orbitTime;
        }

        // Update is called once per frame
        void Update()
        {
            //change star
            if (index >= 8)
            {
                index = 0;
            }

            orbitTimer -= Time.deltaTime;
            if (orbitTimer <= 0)
            {
                orbitSpeed = planetList[index].orbitSpeed;
                orbitDistance = planetList[index].orbitDistance + 20;
                orbitAngle = planetList[index].orbitAngle;
                rotationSpeed = planetList[index].rotationSpeed;
                orbitTimer = orbitTime;
                index++;
            }
            if (index >= 8)
            {
                index = 0;
            }

            //orbit star
            transform.position = new Vector3(orbitStar.transform.position.x + orbitDistance * Mathf.Cos(orbitAngle),
                    orbitStar.transform.position.y + 2,
                    orbitStar.transform.position.z + orbitDistance * Mathf.Sin(orbitAngle));
            orbitAngle += orbitSpeed * Time.deltaTime;

            //look at star
            transform.LookAt(orbitStar.transform);
        }
    }
}
