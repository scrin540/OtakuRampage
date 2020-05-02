using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
            Debug.Break();
    }
}