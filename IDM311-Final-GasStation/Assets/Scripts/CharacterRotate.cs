using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotate : MonoBehaviour
{
    public Transform playerBody;

    public float mouseSpeed = 300f;

    private float xRotation = 0f;

    public GameObject menuObjVending;
    public GameObject InteractObjVending;
    public GameObject menuObjATM;
    public GameObject InteractObjATM;
    public GameObject menuObjTime;
    public GameObject InteractObjTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1)) //right mouse button is clicked
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime; //get mouse location
            float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;
            //Debug.Log("Mouse x is " + mouseX);
            //Debug.Log("Mouse y is " + mouseY);

            //Look Left/Right
            //
            playerBody.Rotate(Vector3.up * mouseX); // up represent "x" dispite "y" being the vertical axis

            //Look Up/Down
            //
            //playerBody.Rotate(Vector3.left * mouseY);
            xRotation += mouseY;
            xRotation = Mathf.Clamp(xRotation, -45f, 45f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);  //local reference the code its attached to
        }

        //check if left click released
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform.name == "ColaMachine")
                {
                    Debug.Log("Vending Machine Clicked");
                    menuObjVending.SetActive(true);
                }
                if (hit.transform.name == "ATM")
                {
                    Debug.Log("ATM Clicked");
                    menuObjATM.SetActive(true);
                }
                if (hit.transform.name == "Bus stop pole")
                {
                    Debug.Log("Bus Stop Clicked");
                    menuObjTime.SetActive(true);
                }
            }
        }
    }
}
