class ClassConstruct
{
	//order is same for static and non-static fields
	///static int x=y; static int y=3; x==0
	private readonly int noChangableAfterConstruct = 10;
	public const string ConstValue = "Never Change!";//is evaluated
	public int Price;
	private int Year;
	static ClassConstruct()
	{
		//once per type
	}
	public int PropertyExample
	{
		get { return Price; }
		set { Price = value; }
	}
	public int ReadOnlyProperty
	{
		get { return Price * Year; }
		//or private set {}
	}
	//compiled to get_XXX, set_XXX(value)
	//

	public int this[int index]
	{
		get
		{
			return Price;// cc[1]
		}
	}
	//compile to get_Item(int)


	///void Foo (ref int x) {...} // OK so far
	///void Foo (out int x) {...} // Compile-time error
	///
	public ClassConstruct() { }
	public ClassConstruct(int price) { Price = price; }
	public ClassConstruct(int price, int year)
		: this(price)
	{
		Year = year;
	}
	//Object initialzier
	// var classConstruct = new ClassConstruct{Price = 20};
	// optional parrameter is baked to new A("a","b","c")
	// can be issue when referencing assembly, when changing constructor
	// other call will produce default call
	~ClassConstruct()
	{
		//base.Finalize();
	}
}

partial class PartialClass : ClassConstruct { }
partial class PartialClass { }

class TestPolyMorphysm
{
	public static void Display(ClassConstruct classConstruct)
	{

	}
	public void DisplayTest()
	{
		Display(new PartialClass());
		//DisplayPC(new ClassConstruct()); //compile time error
	}
	public void DisplayPC(PartialClass partialClass)
	{
		var classConstruct = new ClassConstruct();
		partialClass = new PartialClass();
		classConstruct = partialClass;
		partialClass = (PartialClass)classConstruct;
	}


}