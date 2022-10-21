﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace ReloadedASM.Assembler.Definitions
{
    /// <summary/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct FasmLineHeader
    {
        /// <summary>
        /// 32bit pointer to the file path of the source file.
        /// </summary>
        [FieldOffset(0)]
        public int FilePathPtr;

        /// <summary/>
        [FieldOffset(4)]
        public int LineNumber;

        /// <summary/>
        [FieldOffset(8)]
        public int FileOffset;

        /// <summary>
        /// 32bit pointer to the LINE_HEADER structure for the line which called the macroinstruction.
        /// </summary>
        [FieldOffset(8)]
        public int MacroCallingFilePtr;

        /// <summary>
        /// 32bit pointer to the LINE_HEADER structure for the line within the definition of macroinstruction, which generated this one.
        /// </summary>
        [FieldOffset(12)]
        public int MacroLinePtr;
    }
}
