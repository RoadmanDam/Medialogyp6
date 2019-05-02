using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct NarrationClip {
	public string name;

	public bool isIntermixed;

	public bool haveActivation;

	public string action;

	NarrationPiece narration_piece;

	public AudioClip clip;
}
