﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitModifier_S2
{
	public class Bits : IBitOperator
	{
		public long Value { get; private set; }

		public int Size { get; private set; }

		public Bits(byte value)
		{
			Value = value;
			Size = sizeof(byte);
		}

		public Bits(int value)
		{
			Value = value;
			Size = sizeof(int);
		}

		public Bits(long  value)
		{
			Value = value;
			Size = sizeof(long);
		}

		public bool GetBitByIndex(byte index)
		{
			return (Value & (1 << index)) != 0;
		}

		public void SetBitByIndex(byte index, bool value)
		{
			if (value)
			{
				Value |= (byte)(1 << index);
			}
			else
			{
				Value &= (byte)~(1 << index);
			}
		}

		public bool this[byte index]
		{
			get => GetBitByIndex(index);
			set => SetBitByIndex(index, value);
		}

		public static implicit operator long(Bits bits) { return bits.Value; }
		
		public static explicit operator Bits(long value) { return new(value); }

		// <<<<<<< addition according to Homework >>>>>>>

		// for byte
		public static implicit operator byte(Bits bits) { return bits.Value; }

		public static explicit operator Bits(byte value) { return new(value); }

		// for int
		public static implicit operator int(Bits bits) { return bits.Value; }

		public static explicit operator Bits(int value) { return new(value); }

		// <<<<<<< end of addition >>>>>>>
	}
}

