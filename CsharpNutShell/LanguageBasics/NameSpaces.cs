namespace Outer{
	class Foo{}
	
	namespace Inner{
		class Foo{}
		class NameHiding{
			Foo foo; // Outer.Inner.Foo
			Outer.Foo foo2; //Outer.Foo
		}
	}
}

namespace Repeated{
	class RepClass{}
}
namespace Repeated{
	class RepClass2{}
}
namespace N1
{
class Class1 {}
}
namespace N2
{
using N1;
class Class2 : Class1 {}
}
namespace N2
{
class Class3 : Class1 {} // Compile-time error
}

aliasing

using PropertyInfo2 = System.Reflection.PropertyInfo;
class Program { PropertyInfo2 p; }

// csc /r:W1=Widgets1.dll /r:W2=Widgets2.dll application.cs
extern alias W1;
extern alias W2;
//allow use names
{
W1.Widgets.Widget w1 = new W1.Widgets.Widget();
W2.Widgets.Widget w2 = new W2.Widgets.Widget();
}
//
//
namespace Conflicts{
	class A{
		static void Main(){
	System.Console.WriteLine(new A.B());
	System.Console.WriteLine(new global::A.B());
		}
	}
	class B{}
}
namespace A{
	class B{}
}
