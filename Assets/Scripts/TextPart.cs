using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPart : ReviewPart
{
    private readonly Canvas _canvas;
    private readonly Text _textWidget;
    private readonly string _text;
    
    public TextPart(Canvas canvas, Text textWidget, string text)
    {
        _canvas = canvas;
        _textWidget = textWidget;
        _text = text;
    }
    
    public override void Apply()
    {
        _canvas.gameObject.SetActive(true);
        _textWidget.text = _text;
    }
}
