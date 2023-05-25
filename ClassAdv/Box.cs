using System;

namespace ClassAdv
{
    internal class Box
    {
        private int width;

        public int Width
        {
            get { return width; }
            set { 
                if(value < 0)
                {
                    throw(new Exception("width는 양수여야 합니다:("));
                }
                width = value; 
            }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set {
                if (value < 0)
                {
                    throw(new Exception("width는 양수여야 합니다:("));
                }
                height = value;
            }
        }

        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int GetArea()
        {
            return this.Width * this.Height;
        }

    }
}