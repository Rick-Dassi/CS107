using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaSimples : MonoBehaviour
{
    public Animator _animator;

    private bool _colidindo;
    private bool _portaAbera = false;

    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.E) && _colidindo)
        {
            _portaAbera = true;
            _animator.SetTrigger ("Abrir");
        }
    }

    void OnTriggerEnter (Collider _col)
    {
        if (_col.gameObject.CompareTag ("Door"))
        {
            _colidindo = true;
        }
    }

    void OnTriggerExit (Collider _col)
    {
        if (_col.gameObject.CompareTag ("Door"))
        {
            if (_portaAbera)
            {
                _animator.SetTrigger ("Fechar");
            }

            _colidindo = false;
        }
    }
}
