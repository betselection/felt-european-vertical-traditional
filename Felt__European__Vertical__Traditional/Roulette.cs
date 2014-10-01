//  Roulette.cs
//
//  Author:
//       Victor L. Senior (VLS) <betselection(&)gmail.com>
//
//  Web: 
//       http://betselection.cc/betsoftware/
//
//  Sources:
//       http://github.com/betselection/
//
//  Copyright (c) 2014 Victor L. Senior
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

/// <summary>
/// Roulette.
/// </summary>
namespace Felt__European__Vertical__Traditional
{
    // Directives
    using System;
    using System.Drawing;

    /// <summary>
    /// Roulette class.
    /// </summary>
    public class Roulette
    {
        /// <summary>
        /// Returns color structure for current number
        /// </summary>
        /// <param name="number">Input number</param>
        /// <returns>Color structure, corresponding to either Black, Red or Green</returns>
        public Color GetColor(int number)
        {
            switch (number)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                case 12:
                case 14:
                case 16:
                case 18:
                case 19:
                case 21:
                case 23:
                case 25:
                case 27:
                case 30:
                case 32:
                case 34:
                case 36:

                    // Red number
                    return Color.Red;

                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                case 11:
                case 13:
                case 15:
                case 17:
                case 20:
                case 22:
                case 24:
                case 26:
                case 28:
                case 29:
                case 31:
                case 33:
                case 35:

                    // Black number
                    return Color.Black;

                default:

                    // Anything else = green
                    return Color.Green;
            }
        }
    }
}