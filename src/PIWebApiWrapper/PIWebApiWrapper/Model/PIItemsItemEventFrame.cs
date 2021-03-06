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

	[Guid("C0D449E9-DC50-4F19-852B-36BA18418BA0")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsItemEventFrame
	{
		[DispId(1)]
		PIItemEventFrame[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIItemEventFrame GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIItemEventFrame values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		PIPaginationLinks Links { get; set; }

	}

	[Guid("4AC65F5D-536D-45DE-B32E-3DD18E9CA47D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsItemEventFrame))]
	[ProgId("PIWebAPIWrapper.PIItemsItemEventFrame")]
	[DataContract]

	public class PIItemsItemEventFrame : IPIItemsItemEventFrame
	{
		public PIItemsItemEventFrame()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIItemEventFrame[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIItemEventFrame GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIItemEventFrame values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIItemEventFrame[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPaginationLinks Links { get; set; }

	}
}
