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

        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        //float m_x = Input.GetAxis("Mouse X");
        //float m_y = Input.GetAxis("Mouse Y");

        //scrPlayer.PerformentMovement(h, v);
        //scrPlayer.PerformentRotation(m_x, m_y);

        scrPlayer.CompUpdate(playerInputs);
    }
}