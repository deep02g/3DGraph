
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ShowText : MonoBehaviour
{
    public TextMeshProUGUI output;

    public UnityEvent onClick;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
        //Debug.Log(name + " Game Object Clicked!", this);
        output.text = "Unlock";

        // invoke your event
        onClick.Invoke();
    }


}
