using System;
using UnityEngine;
using DG.Tweening;
using TMPro;

namespace adk
{
    public class CoinBoxManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI coinText;
        [SerializeField] private GameObject coinAnimationImage;
        [SerializeField] private Transform coinImage;

        public Vector3 coinImagePrepos;
        public Vector3 coinImageEndpos;
        public Vector3 coinTextPos;

        private int coinValue = 10;

        private void Start()
        {
            coinImagePrepos = coinAnimationImage.transform.position;
            coinImageEndpos = coinImage.position;
            coinTextPos = coinText.transform.position;
            
            if (PlayerPrefs.GetInt("coin").ToString() != null) {
                coinText.text = PlayerPrefs.GetInt("coin").ToString();
            } 
        }

        public void coinTextChange()
        {
            //increase coin
            int coinTemp = Convert.ToInt32(coinText.text);
            coinTemp += coinValue;
            coinText.text = coinTemp.ToString();
            
            //jump animation
            coinText.transform.DOJump(coinTextPos, 10, 1, .3f);
        }

        public void coinCollectAnimation()
        {
            coinAnimationImage.transform.DOMove(coinImageEndpos, .3f);
            coinAnimationImage.transform.position = coinImagePrepos;
        }
    }
}

