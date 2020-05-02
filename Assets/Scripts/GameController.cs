using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public float gravity = -19.62f;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }
}