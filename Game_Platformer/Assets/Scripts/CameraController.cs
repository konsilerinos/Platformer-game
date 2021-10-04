using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityEngine
{
    public class CameraController : MonoBehaviour
    {
        private Camera camera;

        void Start()
        {
            camera = GetComponent<Camera>();
        }

        public void move_left()
        {
            camera.transform.position = new Vector2(camera.transform.position.x - 150, 0);
        }

        public void move_right()
        {
            camera.transform.position = new Vector2(camera.transform.position.x + 150, 0);
        }
    }
}

