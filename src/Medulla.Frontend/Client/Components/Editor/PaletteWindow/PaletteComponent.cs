﻿// Licensed to the Medulla Contributors under one or more agreements.
// The Medulla Contributors licenses this file to you under the Apache 2.0 license.
// See the LICENSE file in the project root for more information.

namespace Medulla.Frontend.Client.Components.Editor.PaletteWindow
{
    public class PaletteComponent
    {

        public string Name { get; set; } = "{No Component Name}";
        public string SvgString { get; set; } = @"<svg xmlns=""http://www.w3.org/2000/svg"" class=""h-6 w-6"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" style=""width: 48px;"">
        <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M7 8h10M7 12h4m1 8l-4-4H5a2 2 0 01-2-2V6a2 2 0 012-2h14a2 2 0 012 2v8a2 2 0 01-2 2h-3l-4 4z""></path>
            </svg>";

        public string RenderComponentType { get; set; } = default!;

    }
}