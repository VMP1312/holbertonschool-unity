using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Keypad : MonoBehaviour
{

    // Object to be enabled is the keypad. This is needed
    public GameObject objectToEnable;

    // *** Breakdown of header(public) variables *** \\
    // curPassword : Pasword to set. Ive set the password in the project. Note it can be any length and letters or numbers or sysmbols
    // input: What is currently entered
    // displayText : Text area on keypad the password entered gets displayed too.
    // audioData : Play this sound when user enters in password incorrectly too many times

    [Header("Keypad Settings")]
    public string curPassword = "123";
    public string input;
    public Text displayText;
    //public AudioSource audioData;

    //Local private variables
    private bool keypadScreen;
    private float btnClicked = 0;
    private float numOfGuesses;

    public bool pswdStatus = false;

    // Start is called before the first frame update
    void Start()
    {
        btnClicked = 0; // No of times the button was clicked
        numOfGuesses = curPassword.Length; // Set the password length.
    }

    // Update is called once per frame
    void Update()
    {
        if (btnClicked == numOfGuesses)
        {
            if (input == curPassword)
            {
                pswdStatus = true;
    
                // LOG message that password is correct
                Debug.Log("Correct Password!");
                input = ""; //Clear Password
                btnClicked = 0;

            }
            else
            {
                //Reset input varible
                input = "";
                displayText.text = input.ToString();
                //audioData.Play();
                btnClicked = 0;
            }

        }

    }

    // void OnGUI()
    // {
    //     // Action for clicking keypad( GameObject ) on screen
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         RaycastHit hit;
    //         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //         if (Physics.Raycast(ray, out hit, 100.0f))
    //         {
    //             var selection = hit.transform;

    //             if (selection.CompareTag("keypad")) // Tag on the gameobject - Note the gameobject also needs a box collider
    //             {
    //                 keypadScreen = true;

    //                 var selectionRender = selection.GetComponent<Renderer>();
    //                 if (selectionRender != null)
    //                 {
    //                     keypadScreen = true;
    //                 }
    //             }

    //         }
    //     }

    //     // Disable sections when keypadScreen is set to true
    //     if (keypadScreen)
    //     {
    //         objectToEnable.SetActive(true);
    //     }

    // }

    public void PointerClick()
    {
        objectToEnable.SetActive(true);
    }

    public void ValueEntered(string valueEntered)
    {
        switch (valueEntered)
        {
            case "Q": // QUIT
                objectToEnable.SetActive(false);
                btnClicked = 0;
                keypadScreen = false;
                input = "";
                displayText.text = input.ToString();
                break;

            case "C": //CLEAR
                input = "";
                btnClicked = 0;// Clear Guess Count
                displayText.text = input.ToString();
                break;

            default: // Buton clicked add a variable
                btnClicked++; // Add a guess
                input += valueEntered;
                displayText.text = input.ToString();
                break;
        }


    }
}
