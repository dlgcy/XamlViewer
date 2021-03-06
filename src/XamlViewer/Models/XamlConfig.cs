﻿using System.Collections.Generic;
using XamlService.Payloads;

namespace XamlViewer.Models
{
    public class XamlConfig : EditorSetting
    {
        public XamlConfig()
        {
            FontFamily = "Calibri";
            FontSize = 13d;

            WordWrap = false;
            ShowLineNumber = true;
            CodeCompletion = true;

            AutoCompile = true;
            AutoCompileDelay = 2d;

            Files = new List<string>();
            References = new List<string>();
        }

        public List<string> Files { get; set; } 
        public List<string> References { get; set; }
    }
}
