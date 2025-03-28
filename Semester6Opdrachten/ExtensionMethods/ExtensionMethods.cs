using System.Globalization;

namespace Semester6Opdrachten.ExtensionMethods
{
	public enum CurrencyCountry
	{
		USA,
		UK,
		Japan,
		Canada,
		Australia,
		Switzerland,
		Euro
	}

	public static class ExtensionMethods
	{
		public static string ToCurrencyString(this decimal amount, CurrencyCountry country)
		{
			CultureInfo cultureInfo = country switch
			{
				CurrencyCountry.USA => new CultureInfo("en-US"),
				CurrencyCountry.UK => new CultureInfo("en-GB"),
				CurrencyCountry.Japan => new CultureInfo("ja-JP"),
				CurrencyCountry.Canada => new CultureInfo("en-CA"),
				CurrencyCountry.Australia => new CultureInfo("en-AU"),
				CurrencyCountry.Switzerland => new CultureInfo("de-CH"),
				CurrencyCountry.Euro => new CultureInfo("fr-FR"),
				_ => null
			};

			return cultureInfo != null ? amount.ToString("C", cultureInfo) : amount.ToString();
		}

		public static bool IsPalindrome(this string str)
		{
			char[] charArray = str.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray) == str;
		}

		public static DateTime AddMinutes(this DateTime date, int minutes)
		{
			return date.AddMinutes(minutes);
		}

		public static bool IsEven(this int number)
		{
			return number % 2 == 0;
		}

		public static string FirstCharToUpper(this string str)
		{
			if (string.IsNullOrEmpty(str))
				return str;
			return char.ToUpper(str[0]) + str.Substring(1).ToLower();
		}
	}
}

