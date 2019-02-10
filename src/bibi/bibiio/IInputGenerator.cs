using System;

namespace Bibi
{
	public interface IInputGenerator
	{
		bool Read();
		void Write(bool value);
	}
}

