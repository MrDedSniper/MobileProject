using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField] private string _productId;
        
        [Header("Buttons")]
        [SerializeField] private Button _buttonStart;
        [SerializeField] private Button _buttonSettings;
        [SerializeField] private Button _buttonShed;
        [SerializeField] private Button _buttonRewardedAds;
        [SerializeField] private Button _buttonBuyProduct;

       /* private UnityAction _startGameCache;
        private UnityAction _settingsCache;
        private UnityAction _shedCache;
        private UnityAction _RewardedAdsCache;
        private UnityAction _buyProductCahce;*/

        public void Init(UnityAction startGame, UnityAction settings, 
            UnityAction shed, UnityAction playRewardedAds, UnityAction<string> buyProduct)
        {
            /*_startGameCache = startGame;
            _settingsCache = settings;
            _shedCache = shed;
            _RewardedAdsCache = playRewardedAds;
            _buyProductCahce = buyProduct;*/
            
            _buttonStart.onClick.AddListener(startGame);
            _buttonSettings.onClick.AddListener(settings);
            _buttonShed.onClick.AddListener(shed);
            _buttonRewardedAds.onClick.AddListener(playRewardedAds);
            _buttonBuyProduct.onClick.AddListener(() => buyProduct(_productId));
        }
        public void OnDestroy()
        {
            _buttonStart.onClick.RemoveAllListeners();
            _buttonSettings.onClick.RemoveAllListeners();
            _buttonShed.onClick.RemoveAllListeners();
            _buttonRewardedAds.onClick.RemoveAllListeners();
            _buttonBuyProduct.onClick.RemoveAllListeners();
        }
            
    }
}
