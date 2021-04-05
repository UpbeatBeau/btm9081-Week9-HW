using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StackGame : MonoBehaviour
{
    private Stack<string> effects = new Stack<string>();

    public Text display;

    private float timer = 0;
    private float timePerTurn = 5;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        if (timer > timePerTurn) return;

        timer += Time.deltaTime;

        //bunch of faces to make a tower
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            effects.Push("( - v - )");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            effects.Push("( u - u )");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            effects.Push(" ╭[ ᴼᴼ ౪ ᴼᴼ]╮ ");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            effects.Push("( * ~ * )");
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            effects.Push("( ° ʖ ° )");
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            effects.Push("(ಠ _ ಠ)");
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            effects.Push("( ^ _ ^ )");
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            effects.Push("[ ‘ ᴥ ’ ]");
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            effects.Push("  (╯° □ °)╯");
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            effects.Push("<( ' - ' <)  ");
        }

        //once I run out of time show this text and the stack
        if (timer >= timePerTurn)
        {
            display.text = "Woa look at that! \n\n\n\n\n";

            ShowStackEffects();
        }
        else
        {
            display.text = "Use numbers to build your tower \n" + (timePerTurn - timer).ToString("F2");
        }

    }

    private void ShowStackEffects()
    {
        //as long as there is a stack TAKE IT OFF THE TOP (LIFO) and show it
        while (effects.Count > 0)
            display.text += "\n" + effects.Pop();
    }
}
