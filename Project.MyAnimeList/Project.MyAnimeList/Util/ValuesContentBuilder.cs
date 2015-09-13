using System;
using System.Xml.Linq;
using MyAnimeListSharp.Facade;
using MyAnimeListSharp.Formatters;

namespace MyAnimeListSharp.Util
{
	public abstract class ValuesContentBuilder<T> : IValuesContentBuilder<T> where T : MyAnimeListValues
	{
		protected readonly IDateTimeFormatter _dateTimeFormatter;

		protected ValuesContentBuilder()
			: this(new DefaultDateTimeFormatter())
		{
		}

		public abstract XElement BuildContent(T values);

		protected ValuesContentBuilder(IDateTimeFormatter dateTimeFormatter)
		{
			_dateTimeFormatter = dateTimeFormatter;
		}

		protected int GetUnderlyingEnumValue<TIn>(TIn enumValue) where TIn : struct
		{
			if (!typeof(TIn).IsEnum)
				throw new ArgumentException("Argument is not an enumeration", nameof(enumValue));

			return (int)(object)enumValue;
		}
	}
}