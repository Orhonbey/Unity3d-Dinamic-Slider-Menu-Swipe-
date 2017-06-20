using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MarketSliderSwipe : MonoBehaviour
{
    /*
     * Korel Art Games 
     * Sunal Orhon Indie Game Programmer 
     * Açıklama : 
     */


    #region Değişkenler 
    [SerializeField]
    private RectTransform contentPanel; // Content Panel RectTransform Boyutu Değişecek olan Content
    [SerializeField]
    private RectTransform cardPanelRectTransform;// Card Panel Game Object Content Panel Altındaki Cardlar
    [SerializeField]
    private float contentChildCount;// Content altında nekdar Obje olduğunu atıyoruz
    [SerializeField]
    private float cardPanelUIWidth;// card Panel Genişliği
    [SerializeField]
    private float contentUIWidth;// Content Panel Genişliği Atanacak olan Değişken
    [SerializeField]
    private float cardPanelSpacingValue;// Card paneler Arasındaki Boşluk




    #endregion
    // Use this for initialization
    void Start()
    {
         ContentUIHandler();
    }

    #region Content ayarını yapıcağımız fonksiyonu
    /// <summary>
    ///
    /// </summary>
    void ContentUIHandler()
    {

        contentChildCount = contentPanel.childCount;// Content Altındakibütün game Objecleri Alıyorum
        Debug.Log("Content child "+contentChildCount);
        cardPanelUIWidth = cardPanelRectTransform.rect.width;// Card Panel Rect transform genişliği
        Debug.Log("cardPanelWidth"+ cardPanelUIWidth);
        cardPanelSpacingValue = contentPanel.GetComponent<HorizontalLayoutGroup>().spacing;// Cardların ARasındaki mesafe
        Debug.Log("cardPanelSpacingValue"+ cardPanelSpacingValue);
        contentUIWidth = (((cardPanelUIWidth + cardPanelSpacingValue) * contentChildCount)-300);
        Debug.Log(contentUIWidth);
        contentPanel.sizeDelta = new Vector2(contentUIWidth,contentPanel.rect.height);
    }
    #endregion



}
