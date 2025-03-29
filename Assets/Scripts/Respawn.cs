using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Animator animator;

    public void PlayerDamaged(){
        animator.Play("Muerte");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
