using System;
using Scintilla;
using GreenwoodLib.Zeus.ScriptModel;
using GreenwoodLib.Zeus.Templates;
using GreenwoodLib.Zeus.ErrorHandling;
using GreenwoodLib.Zeus.UserInterface;

namespace MyGeneration
{
	/// <summary>
	/// Summary description for ScriptWindow.
	/// </summary>
	public class ScriptWindow : ScintillaNETForm
	{
		public ScriptWindow()
		{

		}
		
		public void ScriptGenerate_Click(object sender, System.EventArgs e)
		{
			ZeusParser parser = new ZeusParser();
		}
		{
			get 
			{
				MemoryStream stream = new MemoryStream();
				StreamWriter writer = new StreamWriter(stream);
				writer.Flush();
				writer.BaseStream.Position = 0;

				return writer;
			}
		}
		{
			get 
			{
				if(null != this.FileName)
				}
				else 
				{
					return null;
				}
			}
		}
		public void DynamicGUI_Display(GuiController gui, IScriptExecutioner executioner) 
		{
			DynamicForm df = new DynamicForm(gui, executioner);
			df.ShowDialog(this);
		}
	}
}