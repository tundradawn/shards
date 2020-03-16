using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackVRObjectMaster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		OVRPose p = OVRPlugin.GetNodePose(OVRPlugin.Node.DeviceObjectZero, OVRPlugin.Step.Render).ToOVRPose();

		if (OVRPlugin.GetNodePositionTracked(OVRPlugin.Node.DeviceObjectZero))
		{
			this.transform.position = p.position;
		}

		if (OVRPlugin.GetNodeOrientationTracked(OVRPlugin.Node.DeviceObjectZero))
		{
			this.transform.rotation = p.orientation;
		}
	}
}