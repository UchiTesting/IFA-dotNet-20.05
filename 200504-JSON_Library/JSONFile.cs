using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace _200504_JSON_Library
{
	[Serializable]
	public class JSONFile<T>
	{
		public string Path { get; set; }
		public T Content { get; set; }

		private const string filter = "JSON files |(*.json)| All Files|(*.*)";

		public JSONFile()
		{

		}

		public void Load()
		{

			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = filter;

			try
			{
				if (openFileDialog.ShowDialog() == true)
				{
					Path = openFileDialog.FileName;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Exception occurred.");
			}

			try
			{
				string jsonstring =File.ReadAllText(Path); 
				List<Book> lb = JsonConvert.DeserializeObject<List<Book>>(jsonstring);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message,"Exception occurred.");
			}
		}

		public void Save()
		{
			if (Path is null)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = filter;

				try
				{
					if (saveFileDialog.ShowDialog() == true)
					{
						Path = saveFileDialog.FileName;
					}
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message, "Exception occurred.");
				}
			}

			try
			{
				string json = JsonConvert.SerializeObject(Content);

				File.WriteAllText(Path,json);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Exception occurred.");
			}
		}
	}
}
