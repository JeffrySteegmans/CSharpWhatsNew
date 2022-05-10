using WhatsNew.PatternMatching;

var circle = new Circle(5);
var rectangle = new Rectangle(420, 1337);
var square = new Rectangle(69, 69);

var shapes = new List<Shape> { circle, rectangle, square };

var randomShape = shapes[new Random().Next(shapes.Count)];

if (randomShape is Circle)
{
    var c1 = randomShape as Circle;
    Console.WriteLine($"Circle with area {c1.Diameter}");
}

//***************
//* c# 7        *
//***************

// No casting is required => Add variable name in if condition
if (randomShape is Circle c2)
{
    Console.WriteLine($"Circle with area {c2.Diameter}");
}

// Switch expression can handle type and even check on properties
switch (randomShape)
{
    case Circle c3:
        Console.WriteLine($"Circle with area {c3.Diameter}");
        break;
    case Rectangle r1 when r1.Height == r1.Width:
        Console.WriteLine($"This is a square!");
        break;
    default:
        Console.WriteLine("Nothing special about this");
        break;
}

//***************
//* c# 8        *
//***************

// Check on properties in if condition
if (randomShape is Circle { Radius: 10 } c4)
{
    Console.WriteLine($"Circle with area {c4.Diameter}");
}

var shapeDetails = randomShape switch
{
    Circle c5 => $"This is a circle with area {c5.Area}",
    Rectangle r2 when r2.Height == r2.Width => $"This is a square",
    { Area: 100 } => "This area is 100",
    _ => "This is a default it didn't match anything"
};
Console.WriteLine(shapeDetails);

//***************
//* c# 9        *
//***************

if (randomShape is not null)
{
    Console.WriteLine($"randomShape is not null");
}

if (randomShape is not Rectangle)
{
    Console.WriteLine($"RandomShape is no rectangle");
}

if (randomShape is Circle { Radius: > 100 and < 200, Area: >= 1000 })
{
    Console.WriteLine($"Circle with Radius between 100 and 200, and an area greater then 1000");
}

var shapeDetails2 = randomShape switch
{
    Circle {Area: > 100 and < 200} => "Circle with area between 100 and 200",
    Circle { Diameter: 100} => "Circle with diameter 100",
    _ => "This is a default it didn't match anything"
};

Console.WriteLine(shapeDetails2);

var areaDetails = randomShape.Area switch
{
    >= 100 and <= 200 => "Circle with area between 100 and 200",
    _ => "This is a default it didn't match anything"
};

Console.WriteLine(areaDetails);

//static class Extensions
//{
//    public static bool IsLetter (this char c) =>
//        c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
//}

//static class helper
//{
//    static decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate)
//        => (groupSize, visitDate.DayOfWeek) switch
//        {
//            (<= 0, _) => throw new ArgumentException("Group size must be positive."),
//            (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
//            (>= 5 and < 10, DayOfWeek.Monday) => 20.0m,
//            (>= 10, DayOfWeek.Monday) => 30.0m,
//            (>= 5 and < 10, _) => 12.0m,
//            (>= 10, _) => 15.0m,
//            _ => 0.0m,
//        };
//}

//***************
//* c# 10       *
//***************

if (randomShape is Rectangle { ShapeInShape.Area: 100 })
{

}