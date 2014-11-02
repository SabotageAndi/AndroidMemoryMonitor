﻿//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Managed.Adb;

namespace AndroidHeapMonitor.Logic
{
    class Dumpsys
    {

        public static string GetMeminfoOfPackage(Device device, string packageName)
        {
            var commandResultReceiver = new CommandResultReceiver();
            device.ExecuteShellCommand(string.Format("dumpsys meminfo {0}", packageName), commandResultReceiver );

            return commandResultReceiver.Result;
        }

        public static string GetMeminfo(Device device)
        {
            var commandResultReceiver = new CommandResultReceiver();
            device.ExecuteShellCommand(string.Format("dumpsys meminfo -c"), commandResultReceiver);

            return commandResultReceiver.Result;
        }

    }
}