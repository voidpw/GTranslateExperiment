﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTranslateFree
{
    class ExternalKeyParseException : Exception
    {
        public ExternalKeyParseException()
            : base("External key parse failed") { }
    }
}
