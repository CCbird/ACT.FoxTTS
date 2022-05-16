﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.FoxTTS.engine
{
    public interface ITTSEngine : IPluginComponent
    {
        string Name { get; }

        void Stop();

        void Speak(string text);
    }
}
