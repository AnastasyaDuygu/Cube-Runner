using UnityEngine;
using UnityEngine.EventSystems;

namespace adk
{
    public class InputHandler : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        [SerializeField] private Transform playerTransform;
        
        [SerializeField] private float inputSensitivity = 5.5f;
        [SerializeField] private float lerpSpeed = 12f;

        private float _pivotPosX;
        private float _pivotDragX;
        private float _targetPosX;
        private void Awake()
        {
            _targetPosX = playerTransform.position.x;
        }
        private void Update()
        {
            var pos = playerTransform.position;
            pos.x = Mathf.Lerp(pos.x, _targetPosX, lerpSpeed * Time.deltaTime);
            playerTransform.position = pos;
            //Debug.Log(_targetPosX);
        }
        public void OnPointerDown(PointerEventData eventData)
        {
            //later add second finger ignore func
            UpdatePivots(playerTransform.position.x, 0);
        }
        public void OnDrag(PointerEventData eventData)
        {
            _targetPosX = CalculatePosX(eventData);
        }
        public void OnPointerUp(PointerEventData eventData)
        {
            _targetPosX = CalculatePosX(eventData);
        }
        private float CalculatePosX(PointerEventData eventData)
        {
            var cumulativeDrag = (eventData.position - eventData.pressPosition) / Screen.dpi; //calc cumulative drag
            var dragX = cumulativeDrag.x - _pivotDragX;
            return _pivotPosX + dragX * inputSensitivity;
        }
        private void UpdatePivots(float posX, float dragX)
        {
            _pivotPosX = posX;
            _pivotDragX = dragX;
        }
    }

}
