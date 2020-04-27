using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public const float GRAVITY = -9.81f;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }
}