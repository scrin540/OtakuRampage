using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waifu : MonoBehaviour {

    private Animator compAni;

    public Transform tnsEnemy;

    public float fuel;
    public float alcance;
    public int indexAnimation;

    private void Awake() {
        compAni = GetComponent<Animator>();

        fuel = 100;
        indexAnimation = Random.Range(0, 3);
        compAni.SetInteger("IndexAnimatic", indexAnimation);
    }

    private void Update() {

        float dist = Vector3.Distance(transform.position, tnsEnemy.position);

        bool isCloser = dist <= alcance;

        compAni.SetBool("EnemiesCloser", isCloser);
        compAni.SetBool("EmptyFuel", fuel <= 0);

        if (dist <= alcance)
            fuel -= Time.deltaTime;
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, alcance);
    }
}