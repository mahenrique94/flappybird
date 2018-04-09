using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour {

    [SerializeField]
    private GameObject gameOver;
    private ObjFactory objFactory;
    private Plane plane;
    private Score score;

	public void endGame() {
        this.changeTimeScale(0);
        this.toggleGameOver();
    }

    public void restartGame() {
        this.plane.restart();
        this.objFactory.destroyAll();
        this.score.restart();
        this.restart();
    }

    private void changeTimeScale(int value) {
        Time.timeScale = value;
    }

    private void Start() {
        this.plane = GameObject.FindObjectOfType<Plane>();
        this.objFactory = GameObject.FindObjectOfType<ObjFactory>();
        this.score = GameObject.FindObjectOfType<Score>();
    }

    private void restart() {
        this.changeTimeScale(1);
        this.toggleGameOver();
    }

    private void toggleGameOver() {
        this.gameOver.SetActive(!this.gameOver.activeSelf);
    }

}
