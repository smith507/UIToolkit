using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class UIHorizontalLayout : UIAbstractContainer
{
	public UIHorizontalLayout( int spacing ) : base( UILayoutType.Horizontal )
	{
		this._spacing = spacing;
	}


}
