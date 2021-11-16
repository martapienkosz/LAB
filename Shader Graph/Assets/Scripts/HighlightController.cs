using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightController : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float highlightSpeed = 8.0f;

    Material heighlightMaterial;
    float currentHighlightAmount = 0.0f;
    bool highlightEnabled = true;

    Coroutine highlight;

    private void Awake()
    {
        heighlightMaterial = meshRenderer.material;
    }

    public void StartHighlight()
    {
        if (!highlightEnabled) return;

        if(highlight != null)
        {
            StopCoroutine(highlight);
        }
        if(enabled)
            highlight = StartCoroutine(Highlight(1.0f));
    }

    public void StopHighlight()
    {
        if (highlight != null)
        {
            StopCoroutine(highlight);
        }
        if(enabled)
            highlight = StartCoroutine(Highlight(0.0f));
    }

    IEnumerator Highlight(float target)
    {
        while(Mathf.Approximately(currentHighlightAmount, target))
        {
            currentHighlightAmount = Mathf.MoveTowards(currentHighlightAmount, target, highlightSpeed * Time.deltaTime);

            heighlightMaterial.SetFloat("_GlowAmount", currentHighlightAmount);

            yield return null;
        }
    }

    public void EnableHighlight()
    {
        highlightEnabled = true;
    }

    public void DisableHighlight()
    {
        highlightEnabled = false;
    }
        
}
