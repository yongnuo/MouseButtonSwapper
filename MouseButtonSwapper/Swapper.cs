using System.Runtime.InteropServices;

namespace SwapMouseButtons;

public class Swapper
{
	[DllImport("user32.dll")]
	public static extern bool SwapMouseButton(bool fSwap);
	//-------------------------------
	public bool Swap()
	{
		if (SwapMouseButton(true))
		{
			SwapMouseButton(false);
			return true;
		}

		return false;
	}
}