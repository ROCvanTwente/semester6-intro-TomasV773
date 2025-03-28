using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2
{
	public interface IVehicle
	{
		int Speed { get; set; }
		int Wheels { get; }
		string Color { get; }
		void Accelerate(int amount);
		void Decelerate(int amount);
		int GetSpeed();
	}

	public class Car : IVehicle
	{
		public int Speed { get; set; } = 0;
		public int Wheels { get; } = 4;
		public string Color { get; }

		public Car(string color)
		{
			Color = color;
		}

		public void Accelerate(int amount)
		{
			Speed += amount;
		}

		public void Decelerate(int amount)
		{
			Speed = Math.Max(0, Speed - amount);
		}

		public int GetSpeed()
		{
			return Speed;
		}
	}

	public class Bicycle : IVehicle
	{
		public int Speed { get; set; } = 0;
		public int Wheels { get; } = 2;
		public string Color { get; }

		public Bicycle(string color)
		{
			Color = color;
		}

		public void Accelerate(int amount)
		{
			Speed += amount;
		}

		public void Decelerate(int amount)
		{
			Speed = Math.Max(0, Speed - amount);
		}

		public int GetSpeed()
		{
			return Speed;
		}
	}

	public class VehicleController
	{
		private IVehicle _vehicle;
		private VehicleView _view;

		public VehicleController(IVehicle vehicle, VehicleView view)
		{
			_vehicle = vehicle;
			_view = view;
			_view.UpdateSpeed(_vehicle.GetSpeed());
		}

		public void Accelerate(int amount)
		{
			_vehicle.Accelerate(amount);
			_view.UpdateSpeed(_vehicle.GetSpeed());
		}

		public void Decelerate(int amount)
		{
			_vehicle.Decelerate(amount);
			_view.UpdateSpeed(_vehicle.GetSpeed());
		}
	}

	public class VehicleView
	{
		public void UpdateSpeed(int speed)
		{
			Console.WriteLine($"Huidige snelheid: {speed} km/u");
		}
	}
}
