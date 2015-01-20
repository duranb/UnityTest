public enum ItemTypes
{
	PowerUp = 0,
	Weapon = 1
}

public class Item {
	ItemTypes _type;
	string _name;
	float _duration;
	float _value;

	public ItemTypes type {
		get { return _type; }
		set { _type = value; }
	}

	public string name {
		get { return _name; }
		set { _name = value; }
	}

	public float duration {
		get { return _duration; }
		set { _duration = value; }
	}

	public float value {
		get { return _value; }
		set { _value = value; }
	}

	public Item(ItemTypes type, string name, float value, float duration = -1) {
		_type = type;
		_name = name;
		_duration = duration;
		_value = value;
	}
}