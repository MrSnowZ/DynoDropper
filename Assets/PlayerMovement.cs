using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlayerMovement : MonoBehaviour

{

// member variable

// This is a comment and won't run any code

private Rigidbody2D theRigidBody;

public float speed;

public float jumpSpeed;

float directionX;

bool canMove = false;

bool isJumping = false;

bool jumpReset = false;



// Start is called before the first frame update

void Start()

{

theRigidBody = GetComponent<Rigidbody2D>();//initialize the class

}



// Update is called once per frame

void Update()

{

directionX = Input.GetAxis("Horizontal");

if(directionX > 0.5f || directionX < -0.5f)

{

canMove = true;

}

else

{

canMove = false;

}

if(Input.GetKeyDown(KeyCode.Space) && jumpReset)//if space bar is pressed

{

//trigger a jump

isJumping = true;

jumpReset = false;

}

}



//fixed update for player movement

private void FixedUpdate()

{

MovePlayer();

if(isJumping)

{

theRigidBody.velocity = new Vector2(theRigidBody.velocity.x,jumpSpeed);

isJumping = false;

}

}

//move player method for motion

void MovePlayer()

{

if(canMove)

{

theRigidBody.velocity = new Vector2(speed*directionX,theRigidBody.velocity.y);

}

else

{

theRigidBody.velocity = new Vector2(0,theRigidBody.velocity.y);

}

}

private void OnCollisionEnter2D(Collision2D collision)

{

jumpReset = true;

}

}