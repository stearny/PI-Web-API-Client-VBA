// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
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

	[Guid("C2401E5F-6FEB-4E3F-B673-C7530034A900")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsDataServer
	{
		[DispId(1)]
		PIDataServer[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIDataServer GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIDataServer values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("EDEE63BC-A195-4951-84E2-15A9088362CA")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsDataServer))]
	[ProgId("PIWebAPIWrapper.PIItemsDataServer")]
	[DataContract]

	public class PIItemsDataServer : IPIItemsDataServer
	{
		public PIItemsDataServer()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIDataServer[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIDataServer GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIDataServer values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIDataServer[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}