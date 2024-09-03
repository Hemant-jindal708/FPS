using UnityEngine;
using UnityEngine.InputSystem;

public class Playercollision : MonoBehaviour
{
    [SerializeField] private PlayerInput pl1;
    [SerializeField] private Player pl;
    [SerializeField] private Score score;
    [SerializeField] private Gameoverpanel gl;
    [SerializeField] private AudioSource a1;
    [SerializeField] private AudioSource a2;
    [SerializeField] private AudioSource a3;
    [SerializeField] private AudioSource a4;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectable")
        {
            Destroy(other.gameObject);
            if (score != null)
            {
                score.addscore(1);
            }
            a1.Play();
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "obstecals")
        {
            gl.GameOver();
            pl.enabled = false;
            pl1.enabled = false;
            a2.Play();
            a4.Stop();
        }
        if (other.gameObject.tag == "finish")
        {
            gl.Win();
            a3.Play();
            a4.Stop();
        }
    }
}