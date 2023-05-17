using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DropmenuSelect : MonoBehaviour
{
    
    

   

    public void HandleNames(int val)
    {
        
        if(val == 0)
        {
            SceneManager.LoadScene("Wave");
        }
        if(val == 1)
        {
            SceneManager.LoadScene("Multi Wave");
        }
        if( val == 2)
        {
            SceneManager.LoadScene("Ripple");
        }
        if (val == 3)
        {
            SceneManager.LoadScene("Sphere");
        }

    }

    
}
