using IField;
using McDroid;
using IPig = IField.Pig;
using MPig = McDroid.Pig;


Sheep sheep = new Sheep();
Cow cow = new Cow();
IPig pig1 = new IPig();
MPig pig2 = new MPig(); 


// --------------------------------------------------------------

namespace IField
{
    public class Sheep { }
    public class Pig { } 
}

namespace McDroid
{
    public class Cow { }
    public class Pig { }
}

