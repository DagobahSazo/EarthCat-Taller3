using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Renderer rnd;

    void Start()
    {
        rnd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rnd.material.mainTextureOffset = new Vector2(rnd.material.mainTextureOffset.x + speed * Time.deltaTime, 0);
    }
}
