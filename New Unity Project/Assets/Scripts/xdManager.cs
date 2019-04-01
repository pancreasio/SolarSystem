using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace gamespace
{
    public class xdManager : MonoBehaviour
    {
        public GameObject prefab;
        public GameObject xdcamera;
        public GameObject sun;
        // Start is called before the first frame update
        void Start()
        {
            for (int i = 1; i < 9; i++)
            {
                GameObject go = Instantiate(prefab);
                go.GetComponent<Planet>().orbitDistance = 20 * i;
                go.GetComponent<Planet>().orbitStar = sun;
                go.GetComponent<Planet>().initialOrbitAngle = Random.Range(-180,180);
                xdcamera.GetComponent<CameraManager>().planetList[i-1] = go.GetComponent<Planet>();
                xdcamera.GetComponent<CameraManager>().orbitStar = sun;
            }



        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
