using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizePanel : MonoBehaviour {

    [SerializeField]
    private RectTransform rectTransformPanel, rectTransformImgBarra;
    public LayoutElement baseLa;

    // Use this for initialization
    void Start () {
       // baseLa = baseConteiner.GetComponent<LayoutElement>();
    }
	
	// Update is called once per frame
	void Update () {
        //muda o tamanho da barra lateral do laço, fica tamanho atual da imagem + o tamanho do painel
        rectTransformImgBarra.sizeDelta = new Vector2(14, rectTransformPanel.rect.height); // rectTransformPanel.rect.height -> pega o tamanho do painel
        baseLa.preferredHeight = rectTransformPanel.rect.height + 64;

    }
}
