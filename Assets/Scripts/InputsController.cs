using UnityEngine;
using System.Collections;

public class InputsController : MonoBehaviour {

    public PlayerController scrPlayer;

    private void Start() {
        scrPlayer.CompStart();
    }

    private void Update() {

        DataPlayer playerInputs = new DataPlayer();

        playerInputs.axis_h = Input.GetAxisRaw("Horizontal");
        playerInputs.axis_v = Input.GetAxisRaw("Vertical");
        playerInputs.mouse_x = Input.GetAxis("Mouse X");
        playerInputs.mouse_y = Input.GetAxis("Mouse Y");
        playerInputs.jump = Input.GetButtonDown("Jump");

        scrPlayer.CompUpdate(playerInputs);
    }
}