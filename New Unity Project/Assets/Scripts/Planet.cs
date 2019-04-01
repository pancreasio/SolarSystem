using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gamespace
{
    public class Planet : MonoBehaviour
    {
        public GameObject orbitStar;
        public string planetName;
        public float orbitSpeed;
        public float orbitDistance;
        public float initialOrbitAngle = 0;
        public float rotationSpeed;

        public float orbitAngle;

        void Start()
        {
            orbitAngle = initialOrbitAngle;
        }

        // Update is called once per frame
        void Update()
        {
            //orbit star
            transform.position = new Vector3(orbitStar.transform.position.x + orbitDistance * Mathf.Cos(orbitAngle),
                orbitStar.transform.position.y,
                orbitStar.transform.position.z + orbitDistance * Mathf.Sin(orbitAngle));
            orbitAngle += orbitSpeed * Time.deltaTime;

            //planet rotation
            transform.Rotate(new Vector3(0, 1, 0), rotationSpeed, Space.Self);
        }
    }
}
