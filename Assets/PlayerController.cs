using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;
public class PlayerController : MonoBehaviour {

    GamePadState state;
    GamePadState prev;
    PlayerIndex playerIndex = PlayerIndex.One;

    public float moveX;
    public float moveZ;
    public float lookX;
    public float lookZ;

    public bool fireDown;

	// Use this for initialization
	void Start ()
    {
		
	}

    int triggerDownR;
	bool isTriggerDownR()
    {
        if(state.Triggers.Right == 1)
        {
            triggerDownR++;
            if(triggerDownR > 1)
            {
                return false;
            }
            return true;
        }
        triggerDownR = 0;
        return false;
    }

	// Update is called once per frame
	void Update ()
    {
        state = GamePad.GetState(playerIndex);
        prev = GamePad.GetState(playerIndex);


        moveX = state.ThumbSticks.Left.X;
        moveZ = state.ThumbSticks.Left.Y;

        lookX = state.ThumbSticks.Right.X;
        lookZ = state.ThumbSticks.Right.Y;

        fireDown = isTriggerDownR();
	}
}
