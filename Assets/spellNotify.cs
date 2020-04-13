using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class spellNotify : MonoBehaviour
{
    private int count = 0;
    public Text spellText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (count == 0)
            {
                count = count + 1;
            }
            else if (count == 1)
            {
                count = 0;
            }
        }
        if(count == 0)
        {
            spellText.text = "Spell: Fire";
        }
        else if (count == 1)
        {
            spellText.text = "Spell: Wind";
        }

    }
}
