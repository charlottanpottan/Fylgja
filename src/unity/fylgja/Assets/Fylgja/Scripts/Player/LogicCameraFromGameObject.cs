using UnityEngine;
using System.Collections;

public class LogicCameraFromGameObject : LogicCamera
{
	public override void UpdateCamera(ref LogicCameraInfo cameraInfo)
	{
		cameraInfo.useSourcePosition = true;
		cameraInfo.sourcePosition = transform.position;
		cameraInfo.useTargetPosition = true;
		cameraInfo.targetPosition = cameraInfo.sourcePosition + transform.rotation * new Vector3(0, 0, 1);
	}

	public override void SetCameraPivot(ref LogicCameraInfo cameraInfo, Vector2 targetPivot)
	{
	}
}
