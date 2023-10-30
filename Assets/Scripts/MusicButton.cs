using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButton : MonoBehaviour
{
    [SerializeField] MusicCarrousel carrousel;
    [SerializeField] int value;
    [SerializeField] float count;

    [SerializeField] bool IsPointed = false;
    public bool hasBeenSelected()
    {
        throw new System.NotImplementedException();
    }


    public void OnPointerEnter()
    {
        IsPointed = true;
        StartCoroutine(Selector());
    }


    public void OnPointerExit()
    {
        IsPointed = false;

        StopAllCoroutines();
        count = 0f;
    }

    IEnumerator Selector()
    {

        while (count < 1f && IsPointed)
        {
            count += Time.deltaTime;
            yield return null;
        }
        ChangeSong();


    }

    public void ChangeSong()
    {
        IsPointed = false;
        carrousel.SetSong(value);
        count = 0f;
        StopAllCoroutines();
    }
}
