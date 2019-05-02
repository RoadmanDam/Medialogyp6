using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narration_o_matic : MonoBehaviour {

	public AudioSource audiosource;

	
	public List<NarrationPiece> narration_pieces = new List<NarrationPiece>();

	int narration_piece_iterator = 0;

	bool piece_playing = false;

	public GameObject miniCube;

	// Use this for initialization
	void Start () {
		foreach(NarrationPiece piece in narration_pieces) {
			piece.narration_o_matic = this.GetComponent<Narration_o_matic>();
		}
		if (!piece_playing) {
			PlayPiece(narration_piece_iterator);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Activate_clip();
		}
	}

	public void PlayPiece(int iteration) {
		piece_playing = true;
		narration_pieces[iteration].PlayNextClip();
	}

	public void PlayNextPiece() {

	}

	public void PlayClip(AudioClip audio) {
		audiosource.PlayOneShot(audio);
	}

	public void PlayNextClipInPiece() {
		narration_pieces[narration_piece_iterator].PlayNextClip();
	}

	public void PieceFinished() {
		piece_playing = false;
		printer("Piece finished");
	}

	public void printer(string msg) {
		print(msg);
	}

	public void Do_action_in_piece(string action) {
		
		switch (action)
		{
			case "RAIN":
				printer("It's gon rain");
			break;
			case "SPAWN CUBE":
				Instantiate(miniCube);
			break;
			default:
				printer("NO REAL ACTION SPECIFIED (Misspell?)");
			break;
		}
	}

	public void Activate_clip() {
		if (!narration_pieces[narration_piece_iterator].currentlyPlayingClip) {
			narration_pieces[narration_piece_iterator].ActivateClip();
		}
	}

}
