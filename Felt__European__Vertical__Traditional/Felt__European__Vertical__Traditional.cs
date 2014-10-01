//  Felt__European__Vertical__Traditional.cs
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
/// Felt European Vertical Traditional.
/// </summary>
namespace Felt__European__Vertical__Traditional
{
    // Directives
    using System;
    using System.Drawing;
    using System.Reflection;
    using System.Windows.Forms;

    /// <summary>
    /// Felt European Vertical Traditional class.
    /// </summary>
    public class Felt__European__Vertical__Traditional : Form
    {
        /// <summary>
        /// Undo button.
        /// </summary>
        private Button undoButton;

        /// <summary>
        /// Button for 36.
        /// </summary>
        private Button button36;

        /// <summary>
        /// Button for 35.
        /// </summary>
        private Button button35;

        /// <summary>
        /// Button for 34.
        /// </summary>
        private Button button34;

        /// <summary>
        /// Button for 33.
        /// </summary>
        private Button button33;

        /// <summary>
        /// Button for 32.
        /// </summary>
        private Button button32;

        /// <summary>
        /// Button for 31.
        /// </summary>
        private Button button31;

        /// <summary>
        /// Button for 30.
        /// </summary>
        private Button button30;

        /// <summary>
        /// Button for 29.
        /// </summary>
        private Button button29;

        /// <summary>
        /// Button for 28.
        /// </summary>
        private Button button28;

        /// <summary>
        /// Button for 27.
        /// </summary>
        private Button button27;

        /// <summary>
        /// Button for 26.
        /// </summary>
        private Button button26;

        /// <summary>
        /// Button for 25.
        /// </summary>
        private Button button25;

        /// <summary>
        /// Button for 24.
        /// </summary>
        private Button button24;

        /// <summary>
        /// Button for 23.
        /// </summary>
        private Button button23;

        /// <summary>
        /// Button for 22.
        /// </summary>
        private Button button22;

        /// <summary>
        /// Button for 21.
        /// </summary>
        private Button button21;

        /// <summary>
        /// Button for 20.
        /// </summary>
        private Button button20;

        /// <summary>
        /// Button for 19.
        /// </summary>
        private Button button19;

        /// <summary>
        /// Button for 18.
        /// </summary>
        private Button button18;

        /// <summary>
        /// Button for 17.
        /// </summary>
        private Button button17;

        /// <summary>
        /// Button for 16.
        /// </summary>
        private Button button16;

        /// <summary>
        /// Button for 15.
        /// </summary>
        private Button button15;

        /// <summary>
        /// Button for 14.
        /// </summary>
        private Button button14;

        /// <summary>
        /// Button for 13.
        /// </summary>
        private Button button13;

        /// <summary>
        /// Button for 12.
        /// </summary>
        private Button button12;

        /// <summary>
        /// Button for 11.
        /// </summary>
        private Button button11;

        /// <summary>
        /// Button for 10.
        /// </summary>
        private Button button10;

        /// <summary>
        /// Button for 9.
        /// </summary>
        private Button button9;

        /// <summary>
        /// Button for 8.
        /// </summary>
        private Button button8;

        /// <summary>
        /// Button for 7.
        /// </summary>
        private Button button7;

        /// <summary>
        /// Button for 6.
        /// </summary>
        private Button button6;

        /// <summary>
        /// Button for 5.
        /// </summary>
        private Button button5;

        /// <summary>
        /// Button for 4.
        /// </summary>
        private Button button4;

        /// <summary>
        /// Button for 3.
        /// </summary>
        private Button button3;

        /// <summary>
        /// Button for 2.
        /// </summary>
        private Button button2;

        /// <summary>
        /// Button for 1.
        /// </summary>
        private Button button1;

        /// <summary>
        /// Button for 0.
        /// </summary>
        private Button button0;

        /// <summary>
        /// The marshal object.
        /// </summary>
        private object marshal = null;

        /// <summary>
        /// Roulette class instance.
        /// </summary>
        private Roulette roulette = new Roulette();

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Felt__European__Vertical__Traditional.Felt__European__Vertical__Traditional"/> class.
        /// </summary>
        public Felt__European__Vertical__Traditional()
        {
            this.button0 = new Button();
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button7 = new Button();
            this.button8 = new Button();
            this.button9 = new Button();
            this.button10 = new Button();
            this.button11 = new Button();
            this.button12 = new Button();
            this.button13 = new Button();
            this.button14 = new Button();
            this.button15 = new Button();
            this.button16 = new Button();
            this.button17 = new Button();
            this.button18 = new Button();
            this.button19 = new Button();
            this.button20 = new Button();
            this.button21 = new Button();
            this.button22 = new Button();
            this.button23 = new Button();
            this.button24 = new Button();
            this.button25 = new Button();
            this.button26 = new Button();
            this.button27 = new Button();
            this.button28 = new Button();
            this.button29 = new Button();
            this.button30 = new Button();
            this.button31 = new Button();
            this.button32 = new Button();
            this.button33 = new Button();
            this.button34 = new Button();
            this.button35 = new Button();
            this.button36 = new Button();
            this.undoButton = new Button();
            this.SuspendLayout();

            // button0
            this.button0.BackColor = System.Drawing.Color.Green;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(7, 4);
            this.button0.Name = "b0";
            this.button0.Size = new System.Drawing.Size(152, 35);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;

            // button1
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 40);
            this.button1.Name = "b1";
            this.button1.Size = new System.Drawing.Size(50, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;

            // button2
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(58, 40);
            this.button2.Name = "b2";
            this.button2.Size = new System.Drawing.Size(50, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;

            // button3
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(109, 40);
            this.button3.Name = "b3";
            this.button3.Size = new System.Drawing.Size(50, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;

            // button4
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(7, 76);
            this.button4.Name = "b4";
            this.button4.Size = new System.Drawing.Size(50, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;

            // button5
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(58, 76);
            this.button5.Name = "b5";
            this.button5.Size = new System.Drawing.Size(50, 35);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;

            // button6
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(109, 76);
            this.button6.Name = "b6";
            this.button6.Size = new System.Drawing.Size(50, 35);
            this.button6.TabIndex = 0;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;

            // button7
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(7, 112);
            this.button7.Name = "b7";
            this.button7.Size = new System.Drawing.Size(50, 35);
            this.button7.TabIndex = 0;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;

            // button8
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(58, 112);
            this.button8.Name = "b8";
            this.button8.Size = new System.Drawing.Size(50, 35);
            this.button8.TabIndex = 0;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;

            // button9
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(109, 112);
            this.button9.Name = "b9";
            this.button9.Size = new System.Drawing.Size(50, 35);
            this.button9.TabIndex = 0;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;

            // button10
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(7, 148);
            this.button10.Name = "b10";
            this.button10.Size = new System.Drawing.Size(50, 35);
            this.button10.TabIndex = 0;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = false;

            // button11
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(58, 148);
            this.button11.Name = "b11";
            this.button11.Size = new System.Drawing.Size(50, 35);
            this.button11.TabIndex = 0;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = false;

            // button12
            this.button12.BackColor = System.Drawing.Color.Red;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(109, 148);
            this.button12.Name = "b12";
            this.button12.Size = new System.Drawing.Size(50, 35);
            this.button12.TabIndex = 0;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = false;

            // button13
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(7, 184);
            this.button13.Name = "b13";
            this.button13.Size = new System.Drawing.Size(50, 35);
            this.button13.TabIndex = 0;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = false;

            // button14
            this.button14.BackColor = System.Drawing.Color.Red;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(58, 184);
            this.button14.Name = "b14";
            this.button14.Size = new System.Drawing.Size(50, 35);
            this.button14.TabIndex = 0;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = false;

            // button15
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(109, 184);
            this.button15.Name = "b15";
            this.button15.Size = new System.Drawing.Size(50, 35);
            this.button15.TabIndex = 0;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = false;

            // button16
            this.button16.BackColor = System.Drawing.Color.Red;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(7, 220);
            this.button16.Name = "b16";
            this.button16.Size = new System.Drawing.Size(50, 35);
            this.button16.TabIndex = 0;
            this.button16.Text = "16";
            this.button16.UseVisualStyleBackColor = false;

            // button17
            this.button17.BackColor = System.Drawing.Color.Black;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(58, 220);
            this.button17.Name = "b17";
            this.button17.Size = new System.Drawing.Size(50, 35);
            this.button17.TabIndex = 0;
            this.button17.Text = "17";
            this.button17.UseVisualStyleBackColor = false;

            // button18
            this.button18.BackColor = System.Drawing.Color.Red;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(109, 220);
            this.button18.Name = "b18";
            this.button18.Size = new System.Drawing.Size(50, 35);
            this.button18.TabIndex = 0;
            this.button18.Text = "18";
            this.button18.UseVisualStyleBackColor = false;

            // button19
            this.button19.BackColor = System.Drawing.Color.Red;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(7, 256);
            this.button19.Name = "b19";
            this.button19.Size = new System.Drawing.Size(50, 35);
            this.button19.TabIndex = 0;
            this.button19.Text = "19";
            this.button19.UseVisualStyleBackColor = false;

            // button20
            this.button20.BackColor = System.Drawing.Color.Black;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(58, 256);
            this.button20.Name = "b20";
            this.button20.Size = new System.Drawing.Size(50, 35);
            this.button20.TabIndex = 0;
            this.button20.Text = "20";
            this.button20.UseVisualStyleBackColor = false;

            // button21
            this.button21.BackColor = System.Drawing.Color.Red;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(109, 256);
            this.button21.Name = "b21";
            this.button21.Size = new System.Drawing.Size(50, 35);
            this.button21.TabIndex = 0;
            this.button21.Text = "21";
            this.button21.UseVisualStyleBackColor = false;

            // button22
            this.button22.BackColor = System.Drawing.Color.Black;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(7, 292);
            this.button22.Name = "b22";
            this.button22.Size = new System.Drawing.Size(50, 35);
            this.button22.TabIndex = 0;
            this.button22.Text = "22";
            this.button22.UseVisualStyleBackColor = false;

            // button23
            this.button23.BackColor = System.Drawing.Color.Red;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(58, 292);
            this.button23.Name = "b23";
            this.button23.Size = new System.Drawing.Size(50, 35);
            this.button23.TabIndex = 0;
            this.button23.Text = "23";
            this.button23.UseVisualStyleBackColor = false;

            // button24
            this.button24.BackColor = System.Drawing.Color.Black;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(109, 292);
            this.button24.Name = "b24";
            this.button24.Size = new System.Drawing.Size(50, 35);
            this.button24.TabIndex = 0;
            this.button24.Text = "24";
            this.button24.UseVisualStyleBackColor = false;

            // button25
            this.button25.BackColor = System.Drawing.Color.Red;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(7, 328);
            this.button25.Name = "b25";
            this.button25.Size = new System.Drawing.Size(50, 35);
            this.button25.TabIndex = 0;
            this.button25.Text = "25";
            this.button25.UseVisualStyleBackColor = false;

            // button26
            this.button26.BackColor = System.Drawing.Color.Black;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(58, 328);
            this.button26.Name = "b26";
            this.button26.Size = new System.Drawing.Size(50, 35);
            this.button26.TabIndex = 0;
            this.button26.Text = "26";
            this.button26.UseVisualStyleBackColor = false;

            // button27
            this.button27.BackColor = System.Drawing.Color.Red;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button27.ForeColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(109, 328);
            this.button27.Name = "b27";
            this.button27.Size = new System.Drawing.Size(50, 35);
            this.button27.TabIndex = 0;
            this.button27.Text = "27";
            this.button27.UseVisualStyleBackColor = false;

            // button28
            this.button28.BackColor = System.Drawing.Color.Black;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(7, 364);
            this.button28.Name = "b28";
            this.button28.Size = new System.Drawing.Size(50, 35);
            this.button28.TabIndex = 0;
            this.button28.Text = "28";
            this.button28.UseVisualStyleBackColor = false;

            // button29
            this.button29.BackColor = System.Drawing.Color.Black;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button29.ForeColor = System.Drawing.Color.White;
            this.button29.Location = new System.Drawing.Point(58, 364);
            this.button29.Name = "b29";
            this.button29.Size = new System.Drawing.Size(50, 35);
            this.button29.TabIndex = 0;
            this.button29.Text = "29";
            this.button29.UseVisualStyleBackColor = false;

            // button30
            this.button30.BackColor = System.Drawing.Color.Red;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button30.ForeColor = System.Drawing.Color.White;
            this.button30.Location = new System.Drawing.Point(109, 364);
            this.button30.Name = "b30";
            this.button30.Size = new System.Drawing.Size(50, 35);
            this.button30.TabIndex = 0;
            this.button30.Text = "30";
            this.button30.UseVisualStyleBackColor = false;

            // button31
            this.button31.BackColor = System.Drawing.Color.Black;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button31.ForeColor = System.Drawing.Color.White;
            this.button31.Location = new System.Drawing.Point(7, 400);
            this.button31.Name = "b31";
            this.button31.Size = new System.Drawing.Size(50, 35);
            this.button31.TabIndex = 0;
            this.button31.Text = "31";
            this.button31.UseVisualStyleBackColor = false;

            // button32
            this.button32.BackColor = System.Drawing.Color.Red;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button32.ForeColor = System.Drawing.Color.White;
            this.button32.Location = new System.Drawing.Point(58, 400);
            this.button32.Name = "b32";
            this.button32.Size = new System.Drawing.Size(50, 35);
            this.button32.TabIndex = 0;
            this.button32.Text = "32";
            this.button32.UseVisualStyleBackColor = false;

            // button33
            this.button33.BackColor = System.Drawing.Color.Black;
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button33.ForeColor = System.Drawing.Color.White;
            this.button33.Location = new System.Drawing.Point(109, 400);
            this.button33.Name = "b33";
            this.button33.Size = new System.Drawing.Size(50, 35);
            this.button33.TabIndex = 0;
            this.button33.Text = "33";
            this.button33.UseVisualStyleBackColor = false;

            // button34
            this.button34.BackColor = System.Drawing.Color.Red;
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button34.ForeColor = System.Drawing.Color.White;
            this.button34.Location = new System.Drawing.Point(7, 436);
            this.button34.Name = "b34";
            this.button34.Size = new System.Drawing.Size(50, 35);
            this.button34.TabIndex = 0;
            this.button34.Text = "34";
            this.button34.UseVisualStyleBackColor = false;

            // button35
            this.button35.BackColor = System.Drawing.Color.Black;
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button35.ForeColor = System.Drawing.Color.White;
            this.button35.Location = new System.Drawing.Point(58, 436);
            this.button35.Name = "b35";
            this.button35.Size = new System.Drawing.Size(50, 35);
            this.button35.TabIndex = 0;
            this.button35.Text = "35";
            this.button35.UseVisualStyleBackColor = false;

            // button36
            this.button36.BackColor = System.Drawing.Color.Red;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.button36.ForeColor = System.Drawing.Color.White;
            this.button36.Location = new System.Drawing.Point(109, 436);
            this.button36.Name = "b36";
            this.button36.Size = new System.Drawing.Size(50, 35);
            this.button36.TabIndex = 0;
            this.button36.Text = "36";
            this.button36.UseVisualStyleBackColor = false;

            // undoButton
            this.undoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.undoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.undoButton.ForeColor = System.Drawing.Color.White;
            this.undoButton.Location = new System.Drawing.Point(7, 472);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(152, 35);
            this.undoButton.TabIndex = 1;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            this.undoButton.MouseDown += new MouseEventHandler(this.UndoButton_MouseDown);
            this.undoButton.MouseEnter += new System.EventHandler(this.UndoButton_MouseEnter);
            this.undoButton.MouseLeave += new System.EventHandler(this.UndoButton_MouseLeave);
            this.undoButton.MouseUp += new MouseEventHandler(this.UndoButton_MouseUp);

            // MainForm
            this.ClientSize = new System.Drawing.Size(166, 509);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FeltEuropeanVerticalTraditional";
            this.Text = "Felt European Vertical Trad.";
            this.ResumeLayout(false);

            // Declare button array
            Button[] buttonArray = { this.button0, this.button1, this.button2, this.button3, this.button4, this.button5, this.button6, this.button7, this.button8, this.button9, this.button10, this.button11, this.button12, this.button13, this.button14, this.button15, this.button16, this.button17, this.button18, this.button19, this.button20, this.button21, this.button22, this.button23, this.button24, this.button25, this.button26, this.button27, this.button28, this.button29, this.button30, this.button31, this.button32, this.button33, this.button34, this.button35, this.button36 };

            // Add event handlers
            foreach (Button button in buttonArray)
            {
                // MouseLeave
                button.MouseLeave += new EventHandler(this.Button_MouseLeave);

                // MouseEnter
                button.MouseEnter += new EventHandler(this.Button_MouseEnter);

                // MouseDown
                button.MouseDown += new MouseEventHandler(this.Button_MouseDown);

                // MouseUp
                button.MouseUp += new MouseEventHandler(this.Button_MouseUp);

                // Click
                button.Click += new EventHandler(this.Button_Click);
            }
        }

        /// <summary>
        /// Initializes module.
        /// </summary>
        /// <param name="passedMarshal">Passed marshal object.</param>
        public void Init(object passedMarshal)
        {
            // Set marshal 
            this.marshal = passedMarshal;

            // Set icon
            this.Icon = (Icon)this.marshal.GetType().GetProperty("Icon").GetValue(this.marshal, null);

            // Show form
            this.Show();
        }

        /// <summary>
        /// Generic handler for button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void Button_Click(object sender, EventArgs e)
        {
            // Send clicked number
            this.marshal.GetType().InvokeMember("Input", BindingFlags.InvokeMethod, null, this.marshal, new object[] { ((Button)sender).Name.Remove(0, 1) });
        }

        /// <summary>
        /// Generic handler for button mouse enter.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Change background
            ((Button)sender).BackColor = Color.Yellow;

            // Colorize text
            ((Button)sender).ForeColor = this.roulette.GetColor(Convert.ToInt32(((Button)sender).Name.Remove(0, 1)));
        }

        /// <summary>
        /// Generic handler for button mouse leave.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            // Change background
            ((Button)sender).BackColor = this.roulette.GetColor(Convert.ToInt32(((Button)sender).Name.Remove(0, 1)));

            // Colorize text
            ((Button)sender).ForeColor = Color.White;
        }

        /// <summary>
        /// Generic handler for button mouse down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            // Check for left button
            if (e.Button == MouseButtons.Left)
            {
                // Change cursor to hand
                ((Button)sender).Cursor = Cursors.Hand;

                // Show light blue background
                ((Button)sender).BackColor = Color.Cyan;
            }
        }

        /// <summary>
        /// Generic handler for button mouse up.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            // Trigger MouseEnter
            this.Button_MouseEnter(sender, e);

            // Change cursor back
            ((Button)sender).Cursor = Cursors.Default;
        }

        /// <summary>
        /// Process undo button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void UndoButton_Click(object sender, EventArgs e)
        {
            // Send undo
            this.marshal.GetType().InvokeMember("Input", BindingFlags.InvokeMethod, null, this.marshal, new object[] { "-U" });
        }

        /// <summary>
        /// Undo button mouse enter.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void UndoButton_MouseEnter(object sender, EventArgs e)
        {
            // Change background
            ((Button)sender).BackColor = Color.Yellow;

            // Colorize text
            ((Button)sender).ForeColor = Color.RoyalBlue;
        }

        /// <summary>
        /// Undo button mouse leave.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void UndoButton_MouseLeave(object sender, EventArgs e)
        {
            // Change background
            ((Button)sender).BackColor = Color.RoyalBlue;

            // Colorize text
            ((Button)sender).ForeColor = Color.White;
        }

        /// <summary>
        /// Undo button mouse up.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void UndoButton_MouseUp(object sender, MouseEventArgs e)
        {
            // Trigger MouseEnter
            this.UndoButton_MouseEnter(sender, e);

            // Change cursor back
            ((Button)sender).Cursor = Cursors.Default;
        }

        /// <summary>
        /// Undo button mouse down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void UndoButton_MouseDown(object sender, MouseEventArgs e)
        {
            // Check for left button
            if (e.Button == MouseButtons.Left)
            {
                // Change cursor to hand
                ((Button)sender).Cursor = Cursors.Hand;

                // Show light blue background
                ((Button)sender).BackColor = Color.Cyan;
            }
        }
    }
}