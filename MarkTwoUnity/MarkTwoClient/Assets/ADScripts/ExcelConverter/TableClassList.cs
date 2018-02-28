[System.Serializable] 
public class Multilingual
{
	public int Num;
	public string Kor;
	public string Eng;
	public string Jpn;
}

[System.Serializable] 
public class PR
{
	public int Num;
	public string Type;
	public string Key;
	public string Value;
	public string Comment;
}

[System.Serializable] 
public class NPC
{
	public int Num;
	public int Property;
	public TagManager.Table.Tag.Weapon Weapon;
	public int Race;
	public byte Grade;
	public byte Level;
	public int HP;
	public int Exp;
	public int CLevelExp;
	public int AddSkill01;
	public int RateSkill01;
	public int AddSkill02;
	public int RateSkill02;
	public int AddSkill03;
	public int RateSkill03;
	public int AddSkill04;
	public int RateSkill04;
	public int AddSkill05;
	public int RateSkill05;
	public int MinGold;
	public int MaxGold;
	public int DropPosibility;
	public int Bag01;
	public int Rate01;
	public int Bag02;
	public int Rate02;
	public int Bag03;
	public int Rate03;
	public int Bag04;
	public int Rate04;
	public int Bag05;
	public int Rate05;
	public string NPC_FileName;
	public string NPC_Prefab;
}

[System.Serializable] 
public class Tag
{
	public int Num;
	public string Type;
	public string Item;
	public string Weapon;
	public string Armor;
}

[System.Serializable] 
public class Item
{
	public int Num;
	public string ItemType;
	public byte Grade;
	public int SetNum;
	public byte LimitLevel;
	public int LimitJob;
	public byte Kind;
	public int EquipLocation;
	public int Buy;
	public int Sell;
	public int BuyCrystal;
	public byte Stacks;
	public byte Attribute;
	public int Material;
	public int HitRate;
	public int Atk;
	public int FireAtk;
	public int WaterAtk;
	public int NatureAtk;
	public int LightAtk;
	public int DarkAtk;
	public int Def;
	public int FireDef;
	public int WaterDef;
	public int NatureDef;
	public int LightDef;
	public int DarkDef;
	public int ActiveSkill;
	public int PassiveSkill;
	public int CharmSkill;
	public int Tooltip;
	public string AtlasName;
	public string imgFileName;
}

