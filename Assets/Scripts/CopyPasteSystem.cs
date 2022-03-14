using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CopyPasteSystem : MonoBehaviour
{
    public InputField inputFieldText;
    public TMP_InputField inputField;

    public void CopyToClipboard()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = inputField.text;
        textEditor.SelectAll();
        textEditor.Copy();  //Copy string from textEditor.text to Clipboard
    }

    public void PasteFromClipboard()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.multiline = true;
        textEditor.Paste();  //Copy string from Clipboard to textEditor.text
        inputField.text = textEditor.text;
    }
}
