using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace meow.GamePlay2D
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerCharacter2D : CharacterController2D
    {

	public float speed = 10.0f;
	public float collisionTestOffset = 0.5f;

	public SpriteRenderer spriteRenderer;
	public Animator animator;

	private Rigidbody2D m_rigidbody;
	
        // Start is called before the first frame update
        void Start()
        {
            m_rigidbody = gameObject.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            float xInput = Input.GetAxis("Horizontal");
            float yInput = Input.GetAxis("Vertical");
            //isTouchingGround = IsTouchingGround();
            Vector2 motion = m_rigidbody.velocity;


            if(xInput != 0.0f)
            {
                motion.x = xInput * speed;
            }

            if(yInput != 0.0f)
            {
                motion.y = yInput * speed;
            }

            m_rigidbody.velocity = motion;
        }
    }
}
