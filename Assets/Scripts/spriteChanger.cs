using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public SpriteRenderer spriteRenderer;
    public Sprite spriteTrue,spriteFalse;
    public void ChangeSprite(bool a)
    {
        if (a)
        {
            spriteRenderer.sprite = spriteTrue;
        }
        else
        {
            spriteRenderer.sprite = spriteFalse;
        }

    }
}
