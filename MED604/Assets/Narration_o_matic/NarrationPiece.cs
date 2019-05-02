using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NarrationPiece {

	public string narration_piece_name;

	public Narration_o_matic narration_o_matic;
	

	[Header("In seconds")]
	[Range(0,60)]
	public float delay = 1;
	[Range(0,60)]
	public float time_between_clips = 1;

	public bool shouldCallback = false;

	public bool currentlyPlayingClip = false;

	public List<NarrationClip> narration_clips;

	[HideInInspector]
	public NarrationClip currentClip;

	int clipIterator = -1;

	public void PlayNextClip() {
		clipIterator++;
		narration_o_matic.printer("Clip "+clipIterator);
		if (clipIterator > narration_clips.Count - 1) {
			clipIterator = -1;
			NarrationPieceFinished();
		} else if (!currentlyPlayingClip) {
			currentlyPlayingClip = true;
			currentClip = narration_clips[clipIterator];
			narration_o_matic.printer(currentClip.name);
			narration_o_matic.GetComponent<Narration_o_matic>().PlayClip(currentClip.clip);
			Action_in_piece(currentClip.action);
			if (clipIterator - 1 > -1) {
				narration_o_matic.StartCoroutine(ClipEnded(currentClip.clip.length, narration_clips[clipIterator-1].haveActivation));
			} else {
				narration_o_matic.StartCoroutine(ClipEnded(currentClip.clip.length));
			}
		}
	}

	private IEnumerator ClipEnded(float clipLength, bool shouldNotAutomaticStart = true)
    {
		yield return new WaitForSeconds(clipLength + (time_between_clips));
		currentlyPlayingClip = false;

		if (!shouldNotAutomaticStart) {
			narration_o_matic.PlayNextClipInPiece();
		} else if (clipIterator+1 > narration_clips.Count - 1) {
			NarrationPieceFinished();
		}
    }

	public void ActivateClip() {
		narration_o_matic.printer(currentlyPlayingClip + "   " + narration_clips[clipIterator+1].haveActivation);
		if (clipIterator + 1 <= narration_clips.Count - 1) {
			if (!currentlyPlayingClip && narration_clips[clipIterator+1].haveActivation) {
				PlayNextClip();
			}
		}
		
	}

	public void NarrationPieceFinished() {
		narration_o_matic.PieceFinished();
	}


	public void Action_in_piece(string action) {
		narration_o_matic.Do_action_in_piece(action);
	}
}
