using static CSHARP2.Cat;
using static CSHARP2.Circle;

namespace CSHARP2
{
	class Program
	{
		static void Main()
		{
			// --- Vehicles ---
			Car car = new Car("Rood");
			VehicleView vehicleView = new VehicleView();
			VehicleController vehicleController = new VehicleController(car, vehicleView);
			vehicleController.Accelerate(10);
			vehicleController.Decelerate(5);

			// --- Shapes ---
			Rectangle rectangle = new Rectangle(5, 10);
			ShapeView shapeView = new ShapeView();
			ShapeController shapeController = new ShapeController(rectangle, shapeView);
			shapeController.ResizeShape(1.5);

			// --- Animals ---
			Dog dog = new Dog("Buddy", 20.5, 5);
			AnimalView animalView = new AnimalView();
			AnimalController animalController = new AnimalController(dog, animalView);
			animalController.UpdateAnimal("Max", 22, 6);

			// --- Logger ---
			string logFilePath = "log.txt";
			FileLogger fileLogger = new FileLogger(logFilePath);
			ConsoleLogger consoleLogger = new ConsoleLogger();
			MultiLogger multiLogger = new MultiLogger(fileLogger, consoleLogger);
			LoggerView loggerView = new LoggerView();
			LoggerController loggerController = new LoggerController(multiLogger, loggerView);

			loggerController.LogMessage("Dit is een testlogbericht.");
		}
	}

}
