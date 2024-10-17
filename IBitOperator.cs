using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitModifier_S2;
public interface IBitOperator
{
	bool GetBitByIndex(byte index);

	void SetBitByIndex(byte index, bool value);
}

