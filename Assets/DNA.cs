using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour
{

    // gene for colour
    public float r;
    public float g;
    public float b;
    public float s;
    bool dead = false;
    public float timeToDie = 0.0f;
    SpriteRenderer spriteRenderer;
    Collider2D sCollider;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        spriteRenderer.color = new Color(r, g, b);
        transform.localScale = new Vector3(s, s, s);
    }

    private void OnMouseDown()
    {
        dead = true;
        timeToDie = PopulationManager.elapsed;
        Debug.Log("dead at: " + timeToDie);
        spriteRenderer.enabled = false;
        sCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
