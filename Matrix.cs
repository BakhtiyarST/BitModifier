using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitModifier_S2;

internal class Matrix<T> : IMatrix<T>
{
	private T[,] arr;

	public Matrix(int rows, int cols)
	{
		arr = new T[rows, cols];
	}
	
	public T this[int row, int col]
	{
		get => arr[row, col];
		set => arr[row, col] = value;
	}

	public void PrintMatrix()
	{
		for (int i=0;i<arr.GetLength(0);i++)
		{
			for (int j=0;j<arr.GetLength(1);j++)
			{
				Console.Write(arr[i,j] + "\t");
			}
			Console.WriteLine();
		}
	}
}
