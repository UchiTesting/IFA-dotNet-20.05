using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace _200504_JSON_Library
{
	class BookConverter : CustomCreationConverter<Book>
	{
		public override Book Create(Type objectType)
		{
			return new Book();
		}
	}
}
