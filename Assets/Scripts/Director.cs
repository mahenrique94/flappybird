using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour {

    [SerializeField]
    private GameObject gameOverImage;

    public void EndGame() {
        Time.timeScale = 0;
        this.gameOverImage.SetActive(true);
    }

}
