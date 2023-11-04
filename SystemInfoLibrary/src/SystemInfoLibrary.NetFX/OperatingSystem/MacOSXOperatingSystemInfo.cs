﻿/*
 * Little Software Stats - .NET Library
 * Copyright (C) 2008-2012 Little Apps (http://www.little-apps.org)
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using SystemInfoLibrary.Hardware;

namespace SystemInfoLibrary.OperatingSystem
{
    internal class MacOSXOperatingSystemInfo : UnixOperatingSystemInfo
    {
        private HardwareInfo _hardware;
        public override HardwareInfo Hardware => _hardware ?? (_hardware = new MacOSXHardwareInfo());

        public override OperatingSystemInfo Update()
        {
            base.Update();

            _hardware = null;

            return this;
        }
    }
}