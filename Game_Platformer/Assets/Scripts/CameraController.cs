using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityEngine
{
    public class CameraController : MonoBehaviour
    {
        private Camera camera;
        private GameObject player;

        void Start()
        {
            camera = GetComponent<Camera>();
            player = GameObject.Find("Player");
        }

        private void FixedUpdate()
        {
            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, -10));
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, -10));
            if (player.transform.position.x > max.x)
                move_right();
            else if (player.transform.position.x < min.x)
                move_left();
            if (player.transform.position.y > max.y)
                move_up();
            else if (player.transform.position.y < min.y)
                move_down();
        }

        public void move_left()
        {
            camera.transform.position = new Vector3(camera.transform.position.x - 40f, camera.transform.position.y, -10);
        }

        public void move_right()
        {
            camera.transform.position = new Vector3(camera.transform.position.x + 40f, camera.transform.position.y, -10);
        }

        public void move_up()
        {
            camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y + 18f, -10);
        }

        public void move_down()
        {
            camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y - 18f, -10);
        }
    }
}

