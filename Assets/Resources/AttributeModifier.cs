using UnityEngine;
using System.Collections;

public enum AttributeModifierTypes
{
	Speed = 0,
	Jump = 1
}

public class AttributeModifier : Item {
	public AttributeModifierTypes modifierType;
}
