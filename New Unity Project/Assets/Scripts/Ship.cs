using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gamespace
{
    public class Ship : MonoBehaviour
    {
        public float speed;
        public float speedBoost;
        public float force;

        private float speedX;
        private float speedY;
        


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            speedX = Input.GetAxis("Horizontal");
            speedY = Input.GetAxis("Vertical");

            if (Input.GetKey(KeyCode.Space)) {
                speedX = speedX* speedBoost;
                speedY = speedY* speedBoost;
            }

            //transform.position = new Vector3(transform.position.x + speedX * speed * Time.deltaTime,0, transform.position.z + speedY * speed * Time.deltaTime);
            Vector3 direction = new Vector3(speedX,0,speedY);
            GetComponent<Rigidbody>().AddForce(direction*force,ForceMode.Impulse);
        }
    }
}