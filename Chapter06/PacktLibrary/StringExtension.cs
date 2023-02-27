using System.Text.RegularExpressions;
namespace Packet.Shared
{
	//Class name means nothing here
	public static class StringExtension
	{
		public static bool IsValidEmail(this string input) => Regex.IsMatch(
			input,
			@"[a-zA-z0-9\.-_]+@[a-za-z0-9\.-_]+");
	}
}

