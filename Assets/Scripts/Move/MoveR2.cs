﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveR2 : AMove
{
	public MoveR2(FaceSelector faceSelector) : base(faceSelector) { }

	public override void DoInstantly()
	{
		this.faceSelector.SetCubiesParent(RotationManager.Instance.transform);
		RotationManager.Instance.RotateInstantly(new Vector3(0, 0, 180));
	}

	public override void UndoInstantly()
	{
		this.faceSelector.SetCubiesParent(RotationManager.Instance.transform);
		RotationManager.Instance.RotateInstantly(new Vector3(0, 0, -180));
	}

	public override void DoGradually()
	{
		this.faceSelector.SetCubiesParent(RotationManager.Instance.transform);
		RotationManager.Instance.RotateGradually(new Vector3(0, 0, 2 * RotationManager.DEGREES_INCREMENT));
	}

	public override void UndoGradually()
	{
		this.faceSelector.SetCubiesParent(RotationManager.Instance.transform);
		RotationManager.Instance.RotateGradually(new Vector3(0, 0, -2 * RotationManager.DEGREES_INCREMENT));
	}

	public override string ToSymbol()
	{
		return "R2";
	}

	public override int ToInt()
	{
		return 16;
	}
}
