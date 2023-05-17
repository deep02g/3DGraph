using UnityEngine;
using System.Collections;
using TMPro;

public class CamMov : MonoBehaviour
{

    

     GameObject gameobject;
    [SerializeField]bool lockToOPos = false;
    Transform OriginalPos;
    Vector3 position;
    Quaternion rotation;
    public TextMeshProUGUI output;

   [SerializeField] float mainSpeed = 10.0f; //regular speed
   [SerializeField] float shiftAdd = 25.0f; //multiplied by how long shift is held.  Basically running
   [SerializeField] float maxShift = 10.0f; //Maximum speed when holdin gshift
   [SerializeField] float camSens = 0.2f; //How sensitive it with mouse
    private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)
    private float totalRun = 1.0f;

    private void Awake()
    {
        gameobject = GameObject.Find("Main Camera").GetComponent<GameObject>();
        position = gameObject.transform.position;   
        rotation = gameObject.transform.rotation;

    }

    void Update()
    {

        if (lockToOPos == false)
        {
            lastMouse = Input.mousePosition - lastMouse;
            lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
            lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
            transform.eulerAngles = lastMouse;
            lastMouse = Input.mousePosition;
            //Mouse  camera angle done.  

            //Keyboard commands
            
            Vector3 p = GetBaseInput();
            if (p.sqrMagnitude > 0)
            { // only move while a direction key is pressed
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    totalRun += Time.deltaTime;
                    p = p * totalRun * shiftAdd;
                    p.x = Mathf.Clamp(p.x, -maxShift, maxShift);
                    p.y = Mathf.Clamp(p.y, -maxShift, maxShift);
                    p.z = Mathf.Clamp(p.z, -maxShift, maxShift);
                }
                else
                {
                    totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
                    p = p * mainSpeed;
                }

                p = p * Time.deltaTime;
                Vector3 newPosition = transform.position;
                if (Input.GetKey(KeyCode.Space))
                { //If player wants to move on X and Z axis only
                    transform.Translate(p);
                    newPosition.x = transform.position.x;
                    newPosition.z = transform.position.z;
                    transform.position = newPosition;
                }
                else
                {
                    transform.Translate(p);
                }
            }
        }
        else
        {
            gameobject.transform.localPosition = OriginalPos.localPosition;

        }
        
    }

    private Vector3 GetBaseInput()
    { //returns the basic values, if it's 0 than it's not active.
        Vector3 p_Velocity = new Vector3();
        if (Input.GetKey(KeyCode.W))
        {
            p_Velocity += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_Velocity += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            p_Velocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            p_Velocity += new Vector3(1, 0, 0);
        }
        return p_Velocity;
    }

    public void ResetAndLockPos()
    {
        //gameObject.transform.position = position;
        //gameObject.transform.rotation = rotation;

        gameObject.transform.SetPositionAndRotation(position, rotation);
        lockToOPos = true;
       // Debug.Log("Clicked");
    } 

    public void ResetPos()
    { 
        gameObject.transform.SetPositionAndRotation(position, rotation);
        lockToOPos = false; 
    } 
    
    public void UnlockMov()
    {
        lockToOPos = false;
        //Debug.Log("Clicked");
        output.text = "You have selected Unlock";

    }
    public void lockMov()
    {
        lockToOPos = true;
        //Debug.Log("Clicked");
        output.text = "You have selected lock";
    }
}