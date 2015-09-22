/*
 *                       Yeppp! library implementation
 *                   This file is auto-generated by Peach-Py,
 *        Portable Efficient Assembly Code-generator in Higher-level Python,
 *                  part of the Yeppp! library infrastructure
 * This file is part of Yeppp! library and licensed under the New BSD license.
 * See LICENSE.txt for the full text of the license.
 */

using System.Runtime.InteropServices;

namespace Yeppp
{

	/// <summary>Basic arithmetic operations</summary>
	public partial class Core
	{


		/// <summary>Computes the sum of single precision (32-bit) floating-point array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe float Sum_V32f_S32f(float[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* v = &vArray[vOffset])
			{
				return Sum_V32f_S32f(v, length);
			}
		}


		/// <summary>Computes the sum of double precision (64-bit) floating-point array elements.</summary>
		/// <exception cref="System.NullReferenceException">If vArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
		public static unsafe double Sum_V64f_S64f(double[] vArray, int vOffset, int length)
		{
			if (vOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (vOffset + length > vArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* v = &vArray[vOffset])
			{
				return Sum_V64f_S64f(v, length);
			}
		}


		/// <summary>Computes the sum of single precision (32-bit) floating-point array elements.</summary>
		/// <param name="v">Pointer to the array of elements which will be summed up.</param>
		/// <param name="length">Length of the array specified by v. If length is zero, the computed sum will be 0.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe float Sum_V32f_S32f(float* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			float sum;
			Status status = yepCore_Sum_V32f_S32f(v, out sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return sum;
		}


		/// <summary>Computes the sum of double precision (64-bit) floating-point array elements.</summary>
		/// <param name="v">Pointer to the array of elements which will be summed up.</param>
		/// <param name="length">Length of the array specified by v. If length is zero, the computed sum will be 0.</param>
		/// <exception cref="System.NullReferenceException">If v is null.</exception>
		/// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe double Sum_V64f_S64f(double* v, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			double sum;
			Status status = yepCore_Sum_V64f_S64f(v, out sum, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
			return sum;
		}


		#if YEP_BUNDLE_LIBRARY

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			private unsafe delegate Status yepCore_Sum_V32f_S32f_Delegate(float* v, out float sum, System.UIntPtr length);
			private static yepCore_Sum_V32f_S32f_Delegate yepCore_Sum_V32f_S32f;

			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			private unsafe delegate Status yepCore_Sum_V64f_S64f_Delegate(double* v, out double sum, System.UIntPtr length);
			private static yepCore_Sum_V64f_S64f_Delegate yepCore_Sum_V64f_S64f;

		#else

			[DllImport("yeppp", CallingConvention=CallingConvention.Cdecl)]
			private static unsafe extern Status yepCore_Sum_V32f_S32f(float* v, out float sum, System.UIntPtr length);

			[DllImport("yeppp", CallingConvention=CallingConvention.Cdecl)]
			private static unsafe extern Status yepCore_Sum_V64f_S64f(double* v, out double sum, System.UIntPtr length);

		#endif

	}

}
