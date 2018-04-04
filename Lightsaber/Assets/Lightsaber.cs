using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightsaber : MonoBehaviour {


    LineRenderer lineRend;
    public Transform startPos;
    public Transform endPos;

    private float textureOffset = 0.0f;
    bool on = true;
    private Vector3 endPosExtendedPos;

	// Use this for initialization
	void Start () {
        lineRend = GetComponent<LineRenderer>();
        endPosExtendedPos = endPos.localPosition;
	}
	
	// Update is called once per frame
	void Update () {


        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(on)
            {
                on = false;
            }
            else
            {
                on = true;

            }
        }

        if(on)
        {
            endPos.localPosition = Vector3.Lerp(endPos.localPosition, endPosExtendedPos, Time.deltaTime * 5f);
        }
        else
        {
            endPos.localPosition = Vector3.Lerp(endPos.localPosition, startPos.localPosition, Time.deltaTime * 3f);

        }

        lineRend.SetPosition(0, startPos.position);
        lineRend.SetPosition(1, endPos.position);


        textureOffset -= Time.deltaTime * 2f;

        if(textureOffset < -10.0f)
        {
            textureOffset += 10.0f;
        }
        lineRend.sharedMaterials[1].SetTextureOffset("_MainTex", new Vector2(textureOffset, 0));
    }
}
