using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class moveSync : NetworkBehaviour {

	[SyncVar]
	private Vector2 syncPos;

	[SerializeField] Transform myTransform;
	[SerializeField] float lerpRate = 15;

	// Update is called once per frame
	void FixedUpdate () 
	{
		TransmitPosition ();
		LerpPosition ();
	
	}
	

	void LerpPosition () 
	{
		if (!isLocalPlayer) 
		{
			myTransform.position = Vector2.Lerp(myTransform.position, syncPos, Time.deltaTime*lerpRate);
		}
	
	}

	[Command]
	void CmdSendPosition (Vector2 pos)
	{
		syncPos = pos;
	}

	[ClientCallback]
	void TransmitPosition()
	{
		if (isLocalPlayer) {
			CmdSendPosition (myTransform.position);
		}
	}
}
