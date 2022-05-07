using System;
using System.Collections.Generic;
using System.Text;

namespace APIWeather.Model
{
	public class RootModel
	{
		public int count { get; set; }
		public List<EntryModel> weathers { get; set; }
	}
}
