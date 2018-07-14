using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberRandomizer : MonoBehaviour
{
    public GameObject[] faces;
    public float xOffset;
    public float yOffset;
    Vector2 tilingVector;

    // Use this for initialization
    void Start()
    {
        SetTexture();
    }

    void SetTexture()
    {
        for (int i = 0; i < faces.Length; i++)
        {

            float x = Random.Range(0, 3);
            float y = Random.Range(0, 2);

            if (x == 0)
                xOffset = 0;
            if (x == 1)
                xOffset = 0.33f;
            if (x == 2)
                xOffset = 0.66f;

            if (y == 0)
                yOffset = 0;
            if (y == 1)
                yOffset = 0.5f;

            tilingVector = new Vector2(yOffset, xOffset);

            var materialInstance = faces[i].GetComponent<Renderer>();
            materialInstance.material.mainTextureOffset = tilingVector;

        }
    }

}
