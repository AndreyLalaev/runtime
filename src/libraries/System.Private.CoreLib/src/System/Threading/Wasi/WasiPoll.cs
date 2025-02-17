// Generated by `wit-bindgen` 0.27.0. DO NOT EDIT!
// <auto-generated />
#nullable enable
using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace WasiPollWorld {

    internal interface IWasiPollWorld {
    }

    internal readonly struct None {}

    [StructLayout(LayoutKind.Sequential)]
    internal readonly struct Result<Ok, Err>
    {
        internal readonly byte Tag;
        private readonly object value;

        private Result(byte tag, object value)
        {
            Tag = tag;
            this.value = value;
        }

        internal static Result<Ok, Err> ok(Ok ok)
        {
            return new Result<Ok, Err>(OK, ok!);
        }

        internal static Result<Ok, Err> err(Err err)
        {
            return new Result<Ok, Err>(ERR, err!);
        }

        internal bool IsOk => Tag == OK;
        internal bool IsErr => Tag == ERR;

        internal Ok AsOk
        {
            get
            {
                if (Tag == OK)
                return (Ok)value;
                else
                throw new ArgumentException("expected OK, got " + Tag);
            }
        }

        internal Err AsErr
        {
            get
            {
                if (Tag == ERR)
                return (Err)value;
                else
                throw new ArgumentException("expected ERR, got " + Tag);
            }
        }

        internal const byte OK = 0;
        internal const byte ERR = 1;
    }

    namespace exports {
        internal static class WasiPollWorld
        {
        }
    }

}
