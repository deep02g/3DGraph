using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TorusDropmenu : MonoBehaviour
{
    
    

   

    public void HandleNamesAndOpen(int val)
    {
        
        if(val == 0)
        {
            SceneManager.LoadScene("Torus");

        }
        if(val == 1)
        {
            SceneManager.LoadScene("Wave");
        }
        if( val == 2)
        {
            SceneManager.LoadScene("Multi Wave");
            
        }
        if (val == 3)
        {
            SceneManager.LoadScene("Ripple");
        }

        if (val == 4)
        {
            SceneManager.LoadScene("Sphere");

        }
        if (val == 5)
        {
            SceneManager.LoadScene("Cycle");

        }

    }

    
}
