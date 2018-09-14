using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System;

public class DropZone : Block, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public void OnPointerEnter(PointerEventData eventData) {
		if(eventData.pointerDrag == null)
			return;

		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if(d != null) {
			d.placeholderParent = this.transform;
            this.addBlock(d);
        }
	}
	
	public bool isPanel(){
		return true;
	}

    public void OnStart(){
        this.blocks = new List<Block>();
    }

    public void OnPointerExit(PointerEventData eventData) {
        if (eventData.pointerDrag == null)
            return;
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null && d.placeholderParent == this.transform) {
            d.placeholderParent = d.parentToReturnTo;
            this.blocks.Remove(d);
        }
    }
		
    public void OnDrop(PointerEventData eventData) {
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if(d != null) {
			d.parentToReturnTo = this.transform;
            this.addBlock(d);
        }
    }
}
