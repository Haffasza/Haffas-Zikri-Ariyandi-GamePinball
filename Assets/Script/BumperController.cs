using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    public VFXManager vfxManager;
    public AudioManager audioManager;
    public ScoreManager scoreManager;

    private Renderer renderer;
    private Animator animator;
    // Start is called before the first frame update
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        renderer.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
     if (collision.collider == bola)
     {
        Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
        bolaRig.velocity *= multiplier;

        animator.SetTrigger("hit");
        //play sfx
        audioManager.PlaySFX(collision.transform.position);
        //play vfx
        vfxManager.PlayVFX(collision.transform.position);
        //score add
        scoreManager.AddScore(score);
     }   
    }
}
