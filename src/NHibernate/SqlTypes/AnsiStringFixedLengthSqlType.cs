using System;
using System.Data;
using System.Data.Common;

namespace NHibernate.SqlTypes
{
	/// <summary>
	/// Describes the details of a <see cref="DbType.AnsiStringFixedLength"/> with the 
	/// information required to to generate an <see cref="DbParameter"/>.
	/// </summary>
	/// <remarks>
	/// This can store the length of the string that the <see cref="DbParameter"/> can hold.
	/// If no value is provided for the length then the <c>Driver</c> is responsible for 
	/// setting the properties on the <see cref="DbParameter"/> correctly.
	/// </remarks>
	[Serializable]
	public class AnsiStringFixedLengthSqlType : SqlType
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AnsiStringFixedLengthSqlType"/> class.
		/// </summary>
		public AnsiStringFixedLengthSqlType() : base(DbType.AnsiStringFixedLength)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AnsiStringFixedLengthSqlType"/> class.
		/// </summary>
		/// <param name="length">The length of the string the <see cref="DbParameter"/> should hold.</param>
		public AnsiStringFixedLengthSqlType(int length) : base(DbType.AnsiStringFixedLength, length)
		{
		}
	}
}