﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jssplay.entity
{
    public class Item: Sprite
    {
        public int type;
        public Item(int x, int y) { 
        //tipos (llama, zapatos, trapasa pared, bomba)
            this.X = x;
            this.Y = y;
           // this.type = type;
            SetType();
            this.Size();
        }

        public override void move(int col, int row)
        {
            
        }
        public override void Size()
        {
            this.Width = this.image.Width;
            this.Height = this.image.Height / 4;
        }
        public void move()
        {
                this.row++;
                if(this.row>1) this.row =0;
        }
        private void SetType() {

            Random r = new Random();
            type = r.Next(1,4);
            if (type == 1)
            {
                /// tipo 1 es llama
                this.image = new System.Drawing.Bitmap(Properties.Resources.Llama);
            }
            if (type == 2)
            {
                /// tipo 2 bomba
                this.image = new System.Drawing.Bitmap(Properties.Resources.Bomba1);
            }
            if (type == 3) {
                //tipo 3 pared
                this.image = new System.Drawing.Bitmap(Properties.Resources.Pared1);
            }
            if (type == 4)
            {
                this.image = new System.Drawing.Bitmap(Properties.Resources.Zapato);
            }
        }
        public void Died() {
            //this.row = 2;
        
        }

    }
}
