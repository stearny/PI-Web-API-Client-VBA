// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Model
{

	[Guid("3CD1BAFF-C932-4E40-A8A9-BB006CB21937")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISearchByAttribute
	{
		[DispId(1)]
		string SearchRoot { get; set; }

		[DispId(2)]
		string ElementTemplate { get; set; }

		[DispId(3)]
		PIWebException WebException { get; set; }

		[DispId(4)]
		PIValueQuery[] ValueQueries { get; set; }

	}

	[Guid("9C3F938A-1C72-49B0-9AB4-F04D4755CBBA")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISearchByAttribute))]
	[ProgId("PIWebAPIWrapper.PISearchByAttribute")]
	[DataContract]

	public class PISearchByAttribute : IPISearchByAttribute
	{
		public PISearchByAttribute()
		{
		}

		[DataMember(Name = "SearchRoot", EmitDefaultValue = false)]
		public string SearchRoot { get; set; }

		[DataMember(Name = "ElementTemplate", EmitDefaultValue = false)]
		public string ElementTemplate { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

		[DataMember(Name = "ValueQueries", EmitDefaultValue = false)]
		public PIValueQuery[] ValueQueries { get; set; }

	}
}
