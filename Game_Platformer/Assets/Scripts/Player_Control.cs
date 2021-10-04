

namespace UnityEngine
{
    public class Player_Control : MonoBehaviour
    {
        public float speed;
        private Rigidbody2D player;
        private BoxCollider2D box_collider;
        private SpriteRenderer spriterend;
        [SerializeField]
        private bool IsGrounded;
        public float Jump_speed;
        private GameObject ground;

        private void Awake()
        {
            player = GetComponent<Rigidbody2D>();
            box_collider = GetComponent<BoxCollider2D>();
            spriterend = GetComponent<SpriteRenderer>();
            ground = GameObject.Find("ground");
            speed = 7f;
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.LeftShift)) speed = 15;
            else speed = 7;
            if (Input.GetKey(KeyCode.D) || Input.GetKey("right"))
            {
                player.velocity = new Vector2(speed, player.velocity.y);
                spriterend.flipX = false;
            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey("left"))
            {
                player.velocity = new Vector2(-speed, player.velocity.y);
                spriterend.flipX = true;
            }
            if ((Input.GetKey(KeyCode.W) || Input.GetKey("up") || Input.GetKey(KeyCode.Space)) && IsGrounded && !spriterend.flipX)
            {
                player.velocity = new Vector2(speed, Jump_speed);
                IsGrounded = false;
            }
            else if ((Input.GetKey(KeyCode.W) || Input.GetKey("up") || Input.GetKey(KeyCode.Space)) && IsGrounded && spriterend.flipX)
            {
                player.velocity = new Vector2(-speed, Jump_speed);
                IsGrounded = false;
            }
            if (box_collider.IsTouching(ground.GetComponent<BoxCollider2D>()))
            {
                IsGrounded = true;
            }
            if(IsGrounded == false && !spriterend.flipX)
            {
                player.velocity = new Vector2(speed, player.velocity.y);
            }
            else if (IsGrounded == false && spriterend.flipX)
            {
                player.velocity = new Vector2(-speed, player.velocity.y);
            }
        }
    }
}

