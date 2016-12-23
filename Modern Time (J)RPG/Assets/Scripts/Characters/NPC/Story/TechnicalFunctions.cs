using UnityEngine;
using UnityEngine.UI;

public class TechnicalFunctions
{

    public GameObject CreateText(Transform canvas_transform, float x, float y, string text_to_print, int font_size, Color text_color)
    {
        GameObject UItextGO = new GameObject("Text2");
        UItextGO.transform.SetParent(canvas_transform);

        RectTransform trans = UItextGO.AddComponent<RectTransform>();
        trans.anchoredPosition = new Vector2(x, y);

        Text text = UItextGO.AddComponent<Text>();
        text.text = text_to_print;
        text.fontSize = font_size;
        text.color = text_color;

        return UItextGO;
    }

    public GameObject CreateButton(Transform canvas_transform, float x, float y, float width, float length, Button.ButtonClickedEvent onClick)
    {
        GameObject UIButtonGO = new GameObject("Button2");
        UIButtonGO.transform.SetParent(canvas_transform);

        RectTransform trans = UIButtonGO.AddComponent<RectTransform>();
        trans.anchoredPosition = new Vector2(x, y);

        Button button = UIButtonGO.AddComponent<Button>();
        button.onClick = onClick;

        return UIButtonGO;
    }
}