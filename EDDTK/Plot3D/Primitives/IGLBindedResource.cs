
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using EDDTK.Plot3D.Rendering.View;

namespace EDDTK.Plot3D.Primitives
{

	public interface IGLBindedResource
	{
		void Mount();
		bool hasMountedOnce();
	}

}


//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================