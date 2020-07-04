using System;

namespace SolidProj
{
	class Program
	{
		private static Computer _computer;
		private static TabletAndPhone _tabletAndPhone;
		public static void Main()
		{
			_computer = new Computer();
			_computer.Test();
			_tabletAndPhone = new TabletAndPhone();
			_tabletAndPhone.Test();
		}
	}

	public class Componet
    {
		internal MotherBoard _mb;
		internal Cpu _cpu;
		internal Ram _ram;

		public Componet()
		{
			_mb = new MotherBoard();
			_cpu = new Cpu();
			_ram = new Ram();
		}
		
        
	}
	
	public class Computer : Componet
	{
		private HardDrive _hd;
		private PowerSupply _ps;
		public Computer()
		{
			_mb = new MotherBoard();
			_cpu = new Cpu();
			_ram = new Ram();
			_hd = new HardDrive();
			_ps = new PowerSupply();
		}

        public void Test()
		{
			Console.WriteLine("-----------------------In Computer Class-----------------------");
			Console.WriteLine(_mb.Motherboarding());
			Console.WriteLine(_cpu.Calculate());
			Console.WriteLine(_ram.StoringData());
			Console.WriteLine(_hd.WritingData());
			Console.WriteLine(_ps.ProducePower());
		}
		
    }

    public class TabletAndPhone : Componet
    {
		private Screen _Screen;
		private Battery _Battery;
		public TabletAndPhone()
		{
			_mb = new MotherBoard();
			_cpu = new Cpu();
			_ram = new Ram();
			_Screen = new Screen();
			_Battery = new Battery();
		}
		public void Test()
		{
			Console.WriteLine("-----------------------In TabletAndPhone Class-----------------------");
			Console.WriteLine(_mb.Motherboarding());
			Console.WriteLine(_cpu.Calculate());
			Console.WriteLine(_ram.StoringData());
			Console.WriteLine(_Screen.Calculate());
			Console.WriteLine(_Battery.SupplyPower());
		}

	}
	public interface IMotherBoard
	{
		public string Motherboarding();

	}

	internal class MotherBoard : IMotherBoard
	{
		public string Motherboarding()
		{
			return "Connecting everything";
		}
	}
	public interface ICpu
	{
		public string Calculate();

	}
	internal class Cpu
	{
		public string Calculate()
		{
			return "Calculating";
		}
	}
	public interface IRam
	{
		public string StoringData();

	}
	internal class Ram : IRam
	{
		public string StoringData()
		{
			return "Storing Data";
		}
	}
	public interface IHardDrive
	{
		public string WritingData();

	}
	internal class HardDrive : IHardDrive
	{
		public string WritingData()
		{
			return "Writing Data";
		}
	}

	public interface IPowerSupply
	{
		public string ProducePower();

	}
	internal class PowerSupply : IPowerSupply
	{
		public string ProducePower()
	{
		return "Producing Power";
	}
	}

	public interface IScreen
	{
		public string Calculate();

	}
	internal class Screen : IScreen
	{
		public string Calculate()
		{
			return "Calculating Screen Time";
		}

	}

	public interface IBattery
	{
		public string SupplyPower();

	}

	internal class Battery : IBattery
	{
		
        public string SupplyPower()
        {
			return "Supply Battery Power";
		}
    }


}