using UnityEngine;
using UnityEngine.UI;

namespace Entities.Characters.NewPlayerController
{
    public class Backpack : MonoBehaviour
    {
        public int nbMaxMunition = 10;
        public Text textAmmo;

        private int _nbMunition;
        private bool _isEmpty;

        private void Awake()
        {
            Reload();
        }

        public bool MunitionThrown()
        {
            _nbMunition--;
            UpdateText();
            if (_nbMunition == 0) _isEmpty = true;
            return _isEmpty;
        }

        public bool Reload()
        {
            _nbMunition = nbMaxMunition;
            UpdateText();
            _isEmpty = false;
            return _isEmpty;
        }

        private void UpdateText()
        {
            textAmmo.text = $"{_nbMunition} x";
        }
    }
}
