using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // public Gloabal/Member Variables
    public int score = 0; // declare a whole number
    public float ItemAmount = 19.95f; // decimal number
    public string PlayerName = "BonBon"; // declare a text
    public bool IsPlayerActive = true; // declare a true/false

    //priavte Global/Member variables
    private int _collectableAmount = 0;
    private float _horizontalInput = 0f;
    private string _userName = "fredricfebear";
    private bool _isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        // make sure score variable is = 0
        score = 0; // assigning a Gloabal/Member variable
        
        //declare a Local variable to track start position
        Vector3 startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // trying to update a Local variable value
        // we can not update a Local variable
        // startPostition = new Vector3(Vector3.right);

        // create a variable to determine object key movement
        float verticalInput = Input.GetAxis("vertical");
    }
}
