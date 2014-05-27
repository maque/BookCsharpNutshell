//base
//sealed
class BaseSealing{
	public int X;
	public BaseSealing(){X=1;}
	public BaseSealing(int x){X=x;}
	
}
class Sealing : BaseSealing{
public sealed override decimal Liability { get { return base.Mortgage; } }

}
// new Sealing(123) illegal
//	public Sealing (int x) : base (x) { } - legal
// new Sealing() //X === 1

/*


public class B
{
int x = 1; // Executes 3rd
public B (int x)
{
... // Executes 4th
}
}
public class D : B
{
int y = 1; // Executes 1st
public D (int x)
: base (x + 1) // Executes 2nd
{
... // Executes 5th
}
}


Overloading and Resolution
Boxing and Unboxing
Static and Runtime Type Checking
The GetType Method and typeof Operator


public class Object
{
public Object();
public extern Type GetType();
public virtual bool Equals (object obj);
public static bool Equals (object objA, object objB);
public static bool ReferenceEquals (object objA, object objB);
public virtual int GetHashCode();
public virtual string ToString();
protected virtual void Finalize();
protected extern object MemberwiseClone();
}


Struct Construction Semantics
Friend Assemblies
Restrictions on Access Modifiers



Access Modifiers
To promote encapsulation, a type or type member may limit its accessibility to other
types and other assemblies by adding one of five access modifiers to the declaration:
public
Fully accessible. This is the implicit accessibility for members of an enum or
interface.
internal
Accessible only within containing assembly or friend assemblies. This is the
default accessibility for non-nested types.
private
Accessible only within containing type. This is the default accessibility for
members of a class or struct.
protected
Accessible only within containing type or subclasses.
protected internal
The union of protected and internal accessibility. Eric Lippert explains it as
follows: Everything is as private as possible by default, and each modifier makes
the thing more accessible. So something that is protected internal is made more
accessible in two ways.

public interface IEnumerator
{
bool MoveNext();
object Current { get; }
void Reset();
}

Extending an Interface
Explicit Interface Implementation

Interface with same method: I2.Foo()
Implemented interace must be overriden in childclass (virtual in parent)
if not virtual then I must be reimplemented by "new"
Alternatives to interface reimplementation

Enum as int 0..*
Type-Safety Issues - enum can have bigger number than it has so else{} on enum isnt good option

*/