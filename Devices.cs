using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitModifier_S2;
public class Devices
{
	public List<IControllable> DeviceList { get; init; }

	public Devices()
	{
		DeviceList =
		[
				new Device(),
				new Device(),
				new Device(),
				new Device(),
				new Device(),
				new Device(),
				new Device(),
				new Device(),
		];
	}

	public void TurnOnOff(Bits bits)
	{
		for (byte i=0; i < DeviceList.Count; i++)
		{
			if (bits[i])
				DeviceList[i].On();
			else
				DeviceList[i].Off();


		}
	}

	public override string ToString()
	{
		return string.Join("", DeviceList.Select(s => s.IsOn ? "1" : "0"));
	}
}

