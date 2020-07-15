using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scratch : MonoBehaviour
{
    public GameObject maskPrefab;
    private bool isPressed = false;

    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 2;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        if(isPressed == true)
        { 
            GameObject maskSprite = Instantiate(maskPrefab, mousePos, Quaternion.identity);
            Invoke("reveal",10);
            maskSprite.transform.parent = gameObject.transform;
        }

        if(Input.GetMouseButtonDown(0))
        {
            isPressed = true;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            isPressed = false;
        }
    }

    void reveal()
    {
        Destroy(this.gameObject);
    }
}
