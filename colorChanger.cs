using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Your In-Game Script must be the same as your Class.
public class ColorChanger : MonoBehaviour
{
    //Reference the Sprite in Game
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                // Change the 'color' property of the 'Sprite Renderer' to 'blue'
                sprite.color = Color.blue;
            }
        }
    }
}
