using TMPro;
using UnityEngine;
using Invokers;


namespace ChangeHandlers
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ScoreChanger : ChangeHandler
    {
        private TextMeshProUGUI _title;
        private int _score;

        protected override void OnAwake()
        {
            _title = GetComponent<TextMeshProUGUI>();
            _score = 0;
        }

        protected override void OnEvent(IInvoker invoker)
        {
            _score += 1;
            _title.text = _score.ToString();
        }
    }
}