using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interact : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI UIText;

    private bool isDoorActive;

    private void Start()
    {
        UIText.gameObject.SetActive(false);
        isDoorActive = false;
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Door")
        {
            UIText.gameObject.SetActive(true);
            UIText.text = "PRESS E TO OPEN THE DOOR";
            isDoorActive = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Door")
        {
            UIText.gameObject.SetActive(false);
            isDoorActive = false;
        }
    }
}
