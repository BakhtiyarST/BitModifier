using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BitModifier_S2;
internal class Device:IControllable
{
	public bool IsOn { get; set; } = false;

	public void On()
	{
		IsOn = true;
		// Console.WriteLine("The device is on");
	}

	public void Off()
	{
		IsOn = false;
		// Console.WriteLine("The device is off");
	}
}

