using Application;
using UnityEngine;

/// <summary>
/// Controls player movement and animation in main area
/// </summary>
public class PlayerController : MonoBehaviour {


	/// <summary>
	/// Store a reference to the animator controller to animate movement
	/// </summary>
	Animator animator;

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
		// Get and store a reference to the animator controller
        animator = GetComponent<Animator> ();
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
            animator.SetTrigger( Constants.PlayerController.JUMP_ANIMATION );
		}
	}
	/* void Update() */


}
