using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitModifier_S2;

internal interface IMatrix<T>
{
	T this[int row, int col] { get; set; }
	void PrintMatrix();
}
