using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuncanMovement : MonoBehaviour
{
    [Header("Assignables")]
    //Assignables
    public Transform playerCam; //Doos waarin de we de camara van de speler bewaren.
    public Transform orientation; // Richting van de speler bewaren//
    private Collider playerCollider; // Dit is een doos wat Bosting dejecteerd//
    public Rigidbody rb;// Doos waarin de de zwaartekracht van de speler in zit 

    [Header("MovementSettings")] // Kopje gemaakt MovementSettings//
    
    public float sensitivity = 50f; //muis gevoeligheid//
    public float moveSpeed = 4500f; //hoe snel je beweeegt//
    public float walkSpeed = 20f; // hoe snel de speler wandelt//
    public float runSpeed = 10f; //Hoe snel de speler beweegt
    public bool grounded; // (waar of niet naar) staat de speler op de grond 
    public bool onWall; // zit de speler op de muur  (waar of niet waar)//




    //Private Floats
    private float wallRunGravity = 1f; //zwaartekracht van de wallRun (hoe lager het  getal hoe minder snel je naar benenden valt//
    private float maxSlopeAngle = 35f; // de helling van de muur kan niet veder dan 35 graden//
    private float wallRunRotation; //hoeveel de Camara draaid tijdens de WallRun//
    private float slideSlowdown = 0.2f; // Hoe snel de speler afremt tijdens de wall Run (Hoe hoger de waarde hoe sneller de speler afremt//
    private float actualWallRotation; //Hoever de Camara is gekanteld tijdens een WallRun//
    private float wallRotationVel;
    private float desiredX;
    private float xRotation;
    private float sensMultiplier = 1f;
    private float jumpCooldown = 0.25f;
    private float jumpForce = 550f;
    private float x;
    private float y;
    private float vel;

}
