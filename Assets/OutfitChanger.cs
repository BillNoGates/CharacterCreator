using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    [Header("Sprite to Change")]
    public SpriteRenderer bodyPart;

    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;
    public void NextOption()
    {
        currentOption++;

        if (currentOption > options.Count -1) 
        { 
            currentOption = 0;
        }

        bodyPart.sprite = options[currentOption];   
    }

    public void PreviousOption()
    {
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = options.Count - 1;
        }

        bodyPart.sprite = options[currentOption];
    }
}
