using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour {

    [SerializeField]
    private GameObject gameOver;
    private Plane plane;
    private ObjFactory objFactory;

	public void endGame() {
        this.changeTimeScale(0);
        this.toggleGameOver();
    }

    public void restartGame() {
        this.plane.restart();
        this.objFactory.destroyAll();
        this.restart();
    }

    private void changeTimeScale(int value) {
        Time.timeScale = value;
    }

    private void Start() {
        this.plane = GameObject.FindObjectOfType<Plane>();
        this.objFactory = GameObject.FindObjectOfType<ObjFactory>();
    }

    private void restart() {
        this.changeTimeScale(1);
        this.toggleGameOver();
    }

    private void toggleGameOver() {
        this.gameOver.SetActive(!this.gameOver.activeSelf);
    }

}
