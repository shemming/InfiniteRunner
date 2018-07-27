using Application;
using UnityEngine;

/// <summary>
/// Controls player movement and animation in main area
/// </summary>
public class PlayerController : MonoBehaviour {

	/// <summary>
	/// Floating point variable to store the player's movement speed.
	/// </summary>
	public float speed;             

	/// <summary>
	/// Store a reference to the Rigidbody2D component required to use 2D Physics.
	/// </summary>
	private Rigidbody2D rb2d;  

	/// <summary>
	/// Store a reference to the animator controller to animate movement
	/// </summary>
	private Animator ani;

	/// <name>
	/// Start
	/// </name>
	/// <summary>
	/// Used for initialization
	/// </summary>
	/// <author>
	/// Sabrina Hemming
	/// </author>
	/// <date>
	/// 4/12/18
	/// </date>
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component 
		rb2d = GetComponent<Rigidbody2D> ();

		// Get and store a reference to the animator controller
		ani = GetComponent<Animator> ();
	}
	/* void Start() */

	/// <name>
	/// Update
	/// </name>
	/// <summary>
	/// Update is called once per frame, used for player animation
	/// </summary>
	/// <author>
	/// Sabrina Hemming
	/// </author>
	/// <date>
	/// 4/12/18
	/// </date>
	void Update() 
	{

		// if player clickes space bar, the character jumps
        if (Input.GetKeyDown (KeyCode.Space))
		{
            ani.SetTrigger( Constants.PlayerController.JUMP_ANIMATION );
		}

		// character is not moving
		//else
		//{
		//	ani.SetBool (Constants.PlayerController.RUN_ANIMATION, true);
		//}
	}
	/* void Update() */


}
