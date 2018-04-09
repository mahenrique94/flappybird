using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private int score;
    [SerializeField]
    private Text scoreText;
    private AudioSource track;

    public void restart() {
        this.score = 0;
        this.updateScore();
    }

	public void scored() {
        this.score++;
        this.track.Play();
        this.updateScore();
    }

	private void Awake() {
        this.track = this.GetComponent<AudioSource>();
	}

	private void updateScore() {
        this.scoreText.text = this.score.ToString();
    }

}
