using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialView : MonoBehaviour
{
    [SerializeField] private CreditView _creditView;
    [SerializeField] private InteractiveBtn _continue;
    [SerializeField] GameObject emojiSelector;
    private void Start()
    {
        _continue.ConfigureOnClick(ContinueButton);
    }

    private void ContinueButton()
    {
        emojiSelector.SetActive(true);
        gameObject.SetActive(false);
        _creditView.gameObject.SetActive(false);
    }

}
