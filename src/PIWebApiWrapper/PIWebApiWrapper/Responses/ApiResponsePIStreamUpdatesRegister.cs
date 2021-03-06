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
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;
using PIWebAPIWrapper.Model;

namespace PIWebAPIWrapper.Responses
{
	[Guid("BE76F7A0-174D-41BF-A32F-5D7666AFFE7C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamUpdatesRegister
	{
		[DispId(1)]
		PIStreamUpdatesRegister Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("DD8E4A5C-E844-4663-A39C-347C69BC8645")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamUpdatesRegister))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamUpdatesRegister")]
	public class ApiResponsePIStreamUpdatesRegister : ApiParentResponse, IApiResponsePIStreamUpdatesRegister
	{
		public PIStreamUpdatesRegister Data { get; set; }
		public ApiResponsePIStreamUpdatesRegister(int statusCode, IDictionary<string, string> headers, PIStreamUpdatesRegister data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
