using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitModifier_S2;

public interface IIndexable<T>
{
	T this[int index] { get; set; }

}
