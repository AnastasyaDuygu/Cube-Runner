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
            var cumulativeDrag = CalculateCumulativeDrag(eventData);
            //
            var dragX = cumulativeDrag.x - _pivotDragX;
            var posX = _pivotPosX + dragX * inputSensitivity;
            _targetPosX = posX;
        }
        public void OnPointerUp(PointerEventData eventData)
        {
            var cumulativeDrag = CalculateCumulativeDrag(eventData);
            //
            var dragX = cumulativeDrag.x - _pivotDragX;
            var posX = _pivotPosX + dragX * inputSensitivity;
            _targetPosX = posX;
        }
        private Vector2 CalculateCumulativeDrag(PointerEventData eventData)
        {
            return (eventData.position - eventData.pressPosition) / Screen.dpi;
        }
        private void UpdatePivots(float posX, float dragX)
        {
            _pivotPosX = posX;
            _pivotDragX = dragX;
        }
    }

}
