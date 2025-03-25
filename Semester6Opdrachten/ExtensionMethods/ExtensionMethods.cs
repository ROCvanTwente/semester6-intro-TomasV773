namespace Semester6Opdrachten.ExtensionMethods
{
	public static class ExtensionMethods
	{
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
	}
}
