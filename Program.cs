// See https://aka.ms/new-console-template for more information
using geometricshapes;


var shapesStore = new ShapesStore();

var rectagle = new Shape() {
    Width = 10,
    Height = 10,
    SidesAmount = 4,
    Scale = 1
};
rectagle.SetPositionForAxis(Axises.X, 10);
rectagle.SetPositionForAxis(Axises.Y, 10);
rectagle.SetPositionForAxis(Axises.Z, 10);

shapesStore.AddShape(rectagle);

var sphere = new Shape() {
    Width = 20,
    Height = 20,
    SidesAmount = 100,
    Scale = 1
};
sphere.SetPositionForAxis(Axises.X, 10);

shapesStore.AddShape(sphere);

foreach (var shape in shapesStore.Shapes) {
    Console.WriteLine(shape.Value);
    Console.WriteLine();
}

shapesStore.RemoveShape(rectagle.Id);

Console.WriteLine("After removing rectangle");
foreach (var shape in shapesStore.Shapes) {
    Console.WriteLine(shape.Value);
    Console.WriteLine();
}

Console.WriteLine("Try to get rectangle");

try {
    var rectangle = shapesStore.GetShape(rectagle.Id);
    Console.WriteLine(rectangle);
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Try to remove rectangle");

try {
    shapesStore.RemoveShape(rectagle.Id);
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}