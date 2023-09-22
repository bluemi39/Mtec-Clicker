using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

public class ClickScript : MonoBehaviour
{

    public TextMeshProUGUI clickText;
    private int clickCount = 0;

    public Image clickImage;

    private float timeElapsed;
    public float delay = 3;
    public float increment = 0.25f;

    void Start()
    {
        
    }


   void Update()
    {
        clickText.text = "Hacks: " + clickCount; // Updates the click text to show the current click count

        //AutoClick(); // Calls the AutoClick function

        if (Input.GetMouseButtonDown(0)) 
        {
           // Click(); // Calls the click function when the left mouse button is pressed
        }


        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            AdjustDelay(increment);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            AdjustDelay(-increment);
        }

        if (clickCount ==3)
        {
            Debug.Log("Congratulations on hacking the safe, you won the game"); //learn from online search
            //delay = 5;
            Debug.Log("Click again to clear the click counter");
            // yield return new
            // WaitForSeconds(1);
            // clickCount = 0;
            //Debug.Break(); //learned from online search
            //Break;
        }

        if (clickCount == 4)
        {
            clickCount = 0;
        }

    }

    private void AutoClick()
    {
        if (timeElapsed < delay)
        {
            timeElapsed += Time.deltaTime;
        }
        else
        {
            Click();
            timeElapsed = 0;
        }
    }

    public void AdjustDelay(float adjValue)
    {
        delay += adjValue;

        if (delay <= 0) delay = 0;


    }

    public void Click()
    {
        clickCount++; // Increments click count by 1 everytime this code runs
        
    }



    public void Hover(bool status)
    {
        if (status)
        {
            clickImage.color = Color.gray;
            //Change color on Hover
        }
        else
        {
            ResetColor();
            //Change color back
        }
    }

    public void ResetColor()
    {
        clickImage.color = Color.white;
    }

    public void SetColor()
    {
       clickImage.color = Color.red;
    }
}
