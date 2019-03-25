using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gamespace
{
    public class Planet : MonoBehaviour
    {
        public Star orbitStar;
        public string planetName;
        public float orbitSpeed;
        public float orbitDistance;
        public float initialOrbitAngle = 0;
        private float orbitAngle;

        void Start()
        {
            Debug.Log("planet " + planetName + " initialized");
            orbitAngle = initialOrbitAngle;
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(planetName + " is orbiting "+ orbitStar.starName);
            transform.position =new Vector3 (orbitStar.transform.position.x + orbitDistance * Mathf.Cos(orbitAngle),
                orbitStar.transform.position.y,
                orbitStar.transform.position.z + orbitDistance * Mathf.Sin(orbitAngle));
            orbitAngle += orbitSpeed * Time.deltaTime;
        }
    }
}
