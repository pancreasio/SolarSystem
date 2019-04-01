using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gamespace
{
    public class Star : MonoBehaviour
    {
        public string starName;
        public float rotationSpeed;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(new Vector3(0,1,0),rotationSpeed,Space.Self);
        }
    }
}