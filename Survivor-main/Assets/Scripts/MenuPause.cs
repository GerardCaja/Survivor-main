using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{

    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    [SerializeField] private GameObject options;
    private Animator _animator;

    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
        options.SetActive(false);

        _animator.SetBool("MenuPause", true);
    }

    public void Reaunudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        options.SetActive(false);
    }

    public void Back()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
        options.SetActive(false);
    }

    public void Options()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(false);
        options.SetActive(true);   
    }
}
