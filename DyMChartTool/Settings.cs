using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DyMChartTool
{
    internal static class Settings
    {
        private const string key = @"HKEY_CURRENT_USER\SOFTWARE\Jono99\DyMChartTool";

        #region Registry Values
        private const string vKeepOpenAfterApply = "KeepOpenAfterApply";
        private const string vIllegalOperations = "IllegalOperations";
        private const string vSortBy = "SortBy";
        private const string vGroupHoldAndSub = "GroupHoldAndSub";
        #endregion

        #region Registry interface
        #region getValue
        private static bool getValue(string value, bool _default)
        {
            object regVal = Registry.GetValue(key, value, null);
            if (regVal == null)
                return _default;
            return ((int)regVal) > 0;
        }

        private static int getValue(string value, int _default)
        {
            object regVal = Registry.GetValue(key, value, null);
            if (regVal == null)
                return _default;
            return (int)regVal;
        }
        #endregion

        #region setValue
        private static void setValue(string value_name, bool value)
        {
            Registry.SetValue(key, value_name, value ? 1 : 0, RegistryValueKind.DWord);
        }

        private static void setValue(string value_name, int value)
        {
            Registry.SetValue(key, value_name, value, RegistryValueKind.DWord);
        }
        #endregion
        #endregion

        /// <summary>
        /// If DyMChartTool should stay open after applying edits in the queue
        /// </summary>
        internal static bool KeepOpenAfterApply
        {
            get
            {
                return getValue(vKeepOpenAfterApply, false);
            }
            set
            {
                setValue(vKeepOpenAfterApply, value);
            }
        }

        /// <summary>
        /// If chart states Dynamix wouldn't allow are allowed
        /// </summary>
        internal static bool IllegalOperations
        {
            get
            {
                return getValue(vIllegalOperations, false);
            }
            set
            {
                setValue(vIllegalOperations, value);
            }
        }

        internal enum SortByValue
        {
            None,
            Time,
            ID
        }

        internal static SortByValue SortBy
        {
            get
            {
                return (SortByValue)getValue(vSortBy, (int)SortByValue.None);
            }
            set
            {
                setValue(vSortBy, (int)value);
            }
        }

        internal static bool GroupHoldAndSub
        {
            get
            {
                return getValue(vGroupHoldAndSub, false);
            }
            set
            {
                setValue(vGroupHoldAndSub, value);
            }
        }
    }
}
