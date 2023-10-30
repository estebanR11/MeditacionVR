using System;
using UnityEngine;

public class InteractiveBtn : MonoBehaviour, IInteractive
{
    private Action _onClick = null;

    public void ConfigureOnClick(Action onClick)
    {
        _onClick = onClick;
    }

    public bool hasBeenSelected()
    {
        throw new NotImplementedException();
    }

    public void OnAction()
    {
        _onClick?.Invoke();

    }

    public void OnPointerClick()
    {
        _onClick?.Invoke();
    }

    public void OnPointerEnter()
    {
        throw new NotImplementedException();
    }

    public void OnPointerExit()
    {
        throw new NotImplementedException();
    }
}
