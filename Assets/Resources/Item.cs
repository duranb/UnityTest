public enum ItemTypes
{
	PowerUp = 0,
	Weapon = 1
}

public class Item {
	ItemTypes _type;
	string _name;

	public ItemTypes type {
		get { return _type; }
		set { _type = value; }
	}

	public string name {
		get { return _name; }
		set { _name = value; }
	}
	
	public Item(ItemTypes type, string name) {
		_type = type;
		_name = name;
	}
}