using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonReviewPart : ReviewPart
{
    private readonly Canvas _canvas;

    public CommonReviewPart(Canvas canvas)
    {
        _canvas = canvas;
    }

    public override void Apply()
    {
        _canvas.gameObject.SetActive(true);
    }
}
