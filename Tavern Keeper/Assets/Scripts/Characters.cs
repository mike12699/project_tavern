using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Characters
{
    public string charactername;
    [HideInInspector]public RectTransform root;
    public bool isMultiLayerCharacter { get { return renderers.renderer == null; } }
    public Characters(string _name)
    {
        CharacterManager cm = CharacterManager.instance;
        GameObject prefab = Resources.Load("Characters/Character[" + _name + "]") as GameObject;
        GameObject ob = GameObject.Instantiate(prefab, cm.characterPanel);
        root = ob.GetComponent<RectTransform>();
        charactername = _name;
        renderers.renderer = ob.GetComponentInChildren<Image>();
        if (isMultiLayerCharacter)
        {
            renderers.bodyRenderer = ob.transform.Find("bodyLayer").GetComponent<Image>();
            renderers.expressionRenderer = ob.transform.Find("expressionLayer").GetComponent<Image>();
        }
    }

    [System.Serializable]
    public class Renderers
    {
        public Image renderer;
        public Image bodyRenderer;
        public Image expressionRenderer;
    }

    Renderers renderers = new Renderers();
}