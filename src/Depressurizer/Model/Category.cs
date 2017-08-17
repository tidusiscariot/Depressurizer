﻿/*
    This file is part of Depressurizer.
    Copyright (C) 2017 Martijn Vegter

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace Depressurizer.Model
{
    /// <summary>
    /// </summary>
    public sealed class Category : IComparable
    {
        /// <summary>
        /// </summary>
        public int Count { set; get; }

        /// <summary>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        public Category(string name)
        {
            Name = name;
            Count = 0;
        }

        /// <summary>
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(object other)
        {
            if (other == null)
            {
                return 1;
            }

            Category otherCat = other as Category;
            if (otherCat == null)
            {
                throw new Exception();
            }

            int compareValue = string.Compare(Name, otherCat.Name, StringComparison.OrdinalIgnoreCase);
            if (compareValue == 0)
            {
                return 0;
            }

            if (string.Equals(Name, "favorite", StringComparison.OrdinalIgnoreCase))
            {
                return -1;
            }

            if (string.Equals(otherCat.Name, "favorite", StringComparison.OrdinalIgnoreCase))
            {
                return 1;
            }

            return compareValue;
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Name;
    }
}