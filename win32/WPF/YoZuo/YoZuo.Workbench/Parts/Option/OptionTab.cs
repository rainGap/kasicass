﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

using Illusion;

namespace YoZuo.Workbench
{
	[MenuPart(PreviousMenu = WorkbenchName.MonitorSystemTab)]
	public class OptionTab : MenuPart
	{
		public OptionTab()
			: base(WorkbenchName.OptionTab)
		{

		}
	}
}
